using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using Windows7.Multitouch;
using Windows7.Multitouch.WinForms;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;

namespace wmtouch_trigger
{
    public partial class MainForm : Form
    {
        int activateSinceResumeCount = 0;
        int activateCount = 0;
        ulong activationTime = 0;
        TouchHandler touchHandler;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // setup power events handling
            SystemEvents.PowerModeChanged += new PowerModeChangedEventHandler(SystemEvents_PowerModeChanged);
            // setup touch events handling
            touchHandler = Windows7.Multitouch.WinForms.Factory.CreateHandler<Windows7.Multitouch.TouchHandler>(this);
            touchHandler.TouchDown += new EventHandler<TouchEventArgs>(touchHandler_TouchDown);
            touchHandler.TouchMove += new EventHandler<TouchEventArgs>(touchHandler_TouchMove);
            touchHandler.TouchUp += new EventHandler<TouchEventArgs>(touchHandler_TouchUp);
            // load settings
            textBox1.Text = Properties.Settings.Default.CommandLine;
            cbActivateOnce.Checked = Properties.Settings.Default.ActivateOncePerResume;
            numActivationHoldoff.Value = Properties.Settings.Default.ActivationHoldoff;
            cbDockBottom.Checked = Properties.Settings.Default.DockBottom;
            Location = new Point(Properties.Settings.Default.FormX, Properties.Settings.Default.FormY);
            Size = new Size(Properties.Settings.Default.FormWidth, Properties.Settings.Default.FormHeight);
            cbDockBottom_CheckedChanged(null, null);
            numTimeout.Value = Properties.Settings.Default.Timeout;
            tbSMTPHost.Text = Properties.Settings.Default.SMTPHost;
            tbUsername.Text = Properties.Settings.Default.Username;
            tbPassword.Text = Properties.Settings.Default.Password;
            cbUseSSL.Checked = Properties.Settings.Default.UseSSL;
            tbToAddr.Text = Properties.Settings.Default.ToAddr;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // save settings
            Properties.Settings.Default.CommandLine = textBox1.Text;
            Properties.Settings.Default.ActivateOncePerResume = cbActivateOnce.Checked;
            Properties.Settings.Default.ActivationHoldoff = (int)numActivationHoldoff.Value;
            Properties.Settings.Default.DockBottom = cbDockBottom.Checked;
            Properties.Settings.Default.FormX = Location.X;
            Properties.Settings.Default.FormY = Location.Y;
            Properties.Settings.Default.FormWidth = Size.Width;
            Properties.Settings.Default.FormHeight = Size.Height;
            Properties.Settings.Default.Timeout = (int)numTimeout.Value;
            Properties.Settings.Default.SMTPHost = tbSMTPHost.Text;
            Properties.Settings.Default.Username = tbUsername.Text;
            Properties.Settings.Default.Password = tbPassword.Text;
            Properties.Settings.Default.UseSSL = cbUseSSL.Checked;
            Properties.Settings.Default.ToAddr = tbToAddr.Text;
            Properties.Settings.Default.Save();
        }

        void SystemEvents_PowerModeChanged(object sender, PowerModeChangedEventArgs e)
        {
            switch (e.Mode)
            {
                case PowerModes.Suspend:
                    break;
                case PowerModes.Resume:
                    activateSinceResumeCount = 0;
                    break;
            }
        }

        void touchHandler_TouchDown(object sender, Windows7.Multitouch.TouchEventArgs e)
        {
            ActivateCommand();
        }

        void touchHandler_TouchMove(object sender, Windows7.Multitouch.TouchEventArgs e)
        {
        }

        void touchHandler_TouchUp(object sender, Windows7.Multitouch.TouchEventArgs e)
        {
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            ActivateCommand();
        }

        private void ActivateCommand()
        {
            ulong tickCount = (ulong)Environment.TickCount; // Environment.TickCount can be negative after 25 days
            if (cbActivateOnce.Checked && activateSinceResumeCount > 0)
                return;
            if (numActivationHoldoff.Value > 0)
            {
                if (tickCount - activationTime < numActivationHoldoff.Value)
                    return;
            }
            activateSinceResumeCount++;
            activateCount++;
            activationTime = tickCount;
            try
            {
                System.Diagnostics.Process.Start(textBox1.Text);
            }
            catch (Exception e)
            {
            }
            Text = string.Format("wmtouch trigger ({0})", activateCount);
            // start timer
            if (numTimeout.Value != 0)
            {
                tmrEmail.Enabled = false;
                tmrEmail.Interval = (int)numTimeout.Value * 1000;
                tmrEmail.Enabled = true;
                tmrEmailTime_Tick(null, null);
                btnStopTimer.Visible = true;
            }
        }

        private void textBox1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
                textBox1.Text = file;
        }

        private void textBox1_DragEnter(object sender, DragEventArgs e)
        {
            // does not trigger if app is admin and explorer is not =(
            e.Effect = DragDropEffects.Move;
        }

        private void cbDockBottom_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDockBottom.Checked)
                panel1.Dock = DockStyle.Bottom;
            else
                panel1.Dock = DockStyle.Top;
        }

        private void SendMail(string smtphost, string username, string password, string toaddr, bool useSSL)
        {
            try
            {
                SmtpClient smtpClient = new SmtpClient(smtphost);

                // set smtp-client with basicAuthentication
                smtpClient.UseDefaultCredentials = false;
                System.Net.NetworkCredential basicAuthenticationInfo = new
                   System.Net.NetworkCredential(username, password);
                smtpClient.Credentials = basicAuthenticationInfo;
                smtpClient.EnableSsl = useSSL;

                // add from,to mailaddresses
                MailAddress from = new MailAddress("wmtouch_trigger@noreply.com");
                MailAddress to = new MailAddress(toaddr);
                MailMessage myMail = new System.Net.Mail.MailMessage(from, to);

                // set subject and encoding
                myMail.Subject = "wmtouch_trigger timeout!";
                myMail.SubjectEncoding = System.Text.Encoding.UTF8;

                // set body-message and encoding
                myMail.Body = string.Format("After {0} iterations of the command \"{1}\" the touch timed out (timeout = {2} sec)",
                    activateCount, textBox1.Text, (int)numTimeout.Value);
                myMail.BodyEncoding = System.Text.Encoding.UTF8;
                // text or html
                myMail.IsBodyHtml = false;

                smtpClient.Send(myMail);
            }

            catch (SmtpException ex)
            {
                throw new ApplicationException
                  ("SmtpException has occured: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void tmrEmail_Tick(object sender, EventArgs e)
        {
            tmrEmail.Enabled = false;
            btnStopTimer.Visible = false;
            SendMail(tbSMTPHost.Text, tbUsername.Text, tbPassword.Text, tbToAddr.Text, cbUseSSL.Checked);
        }

        private void btnStopTimer_Click(object sender, EventArgs e)
        {
            tmrEmail.Enabled = false;
            btnStopTimer.Visible = false;
        }

        private void tmrEmailTime_Tick(object sender, EventArgs e)
        {
            int timeElapsed = (int)(((ulong)Environment.TickCount - activationTime) / 1000);
            int timeLeft = (int)numTimeout.Value - timeElapsed;
            btnStopTimer.Text = string.Format("Stop Timer ({0})", timeLeft);
        }
    }
}
