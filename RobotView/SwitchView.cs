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
    public partial class SwitchView : UserControl
    {
        private Switch theSwitch;

        public SwitchView()
        {
            InitializeComponent();
        }

        public bool State
        {
            set
            {
                this.pictureBoxSwitch.Image = value ? Resources.Resource.SwitchOn : Resources.Resource.SwitchOff;
            }
        }

        public Switch Switch
        {
            get
            {
                return this.theSwitch;
            }
            set
            {
                this.theSwitch = value;
                this.State = this.theSwitch.SwitchEnabled;

                this.theSwitch.SwitchStateChanged += (sender, args) =>
                {
                    this.State = args.SwitchEnabled;
                };
            }
        }
    }
}
