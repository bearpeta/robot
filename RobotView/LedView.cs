using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Hslu.Csa.Team6.RobotCtrl.Output;

namespace Hslu.Csa.Team6.RobotView
{
    public partial class LedView : UserControl
    {
        private Led led;
        private bool state;

        public LedView()
        {
            InitializeComponent();
        }

        public bool State
        {
            get
            {
                return this.state;
            }
            set
            {
                this.state = value;
                this.pictureBoxLed.Image = this.state ? Resources.Resource.LedOn : Resources.Resource.LedOff;
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
                this.led = value;
            }
        }
    }
}
