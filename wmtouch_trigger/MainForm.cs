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

namespace wmtouch_trigger
{
    public partial class MainForm : Form
    {
        int activateSinceResumeCount = 0;
        int activateCount = 0;
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
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // save settings
            Properties.Settings.Default.CommandLine = textBox1.Text;
            Properties.Settings.Default.ActivateOncePerResume = cbActivateOnce.Checked;
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
            if (cbActivateOnce.Checked && activateSinceResumeCount > 0)
                return;
            activateSinceResumeCount++;
            activateCount++;
            try
            {
                System.Diagnostics.Process.Start(textBox1.Text);
            }
            catch (Exception e)
            {
            }
            Text = string.Format("wmtouch trigger ({0})", activateCount);
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
    }
}
