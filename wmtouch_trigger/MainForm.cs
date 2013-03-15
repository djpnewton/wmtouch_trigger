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
        }

        void SystemEvents_PowerModeChanged(object sender, PowerModeChangedEventArgs e)
        {
            switch (e.Mode)
            {
                case PowerModes.Suspend:
                    break;
                case PowerModes.Resume:
                    activateCount = 0;
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
            if (cbActivateOnce.Checked && activateCount > 0)
                return;
            activateCount++;
            try
            {
                System.Diagnostics.Process.Start(textBox1.Text);
            }
            catch (Exception e)
            {
            }
        }
    }
}
