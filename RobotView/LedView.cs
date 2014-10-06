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
                this.pictureBoxLed.Image = value ? Resources.Resource.LedOn : Resources.Resource.LedOff;
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
                this.State = this.Led.LedEnabled;
                this.Led.LedStateChanged += (sender, args) =>
                    {
                        this.State = args.LedEnabled;
                    };
            }
        }
    }
}
