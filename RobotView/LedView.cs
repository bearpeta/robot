using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Hslu.Csa.Team6.RobotCtrl;

namespace Hslu.Csa.Team6.RobotView
{
    public partial class LedView : UserControl
    {
        private Led led;

        public LedView()
        {
            InitializeComponent();
        }

        public bool State
        {
            set
            {
                this.pictureBoxLed.Invoke((Action)(() =>
                  this.pictureBoxLed.Image = value ? Resources.Resource.LedOn : Resources.Resource.LedOff
               ));
            }
        }

        public Led Led
        {
            get
            {
                return this.led;
            }
            set
            {
                if (this.led != null)
                {
                    this.Led.LedStateChanged -= HandleLedChangedEvent;
                }

                this.led = value;
                this.State = this.Led.LedEnabled;

                if (this.led != null)
                {
                    this.Led.LedStateChanged += HandleLedChangedEvent;
                }
            }
        }

        private void HandleLedChangedEvent(object sender, LedEventArgs args)
        {
            this.State = args.LedEnabled;
        }
    }
}
