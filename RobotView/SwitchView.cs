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
    public partial class SwitchView : UserControl
    {
        private bool state;

        public SwitchView()
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
                this.pictureBoxSwitch.Image = this.state ? Resources.Resource.SwitchOn : Resources.Resource.SwitchOff;
            }
        }
    }
}
