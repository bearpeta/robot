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
                this.pictureBoxSwitch.Invoke((Action)(() =>
                
                    this.pictureBoxSwitch.Image = value ? Resources.Resource.SwitchOn : Resources.Resource.SwitchOff
                ));  
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
                if (this.theSwitch != null)
                {
                    this.theSwitch.SwitchStateChanged -= this.HandleSwitchChangedEvent;
                }

                this.theSwitch = value;
                this.State = this.theSwitch.SwitchEnabled;

                if (this.theSwitch != null)
                {
                    this.theSwitch.SwitchStateChanged += this.HandleSwitchChangedEvent;
                }
            }
        }

        private void HandleSwitchChangedEvent(object sender, SwitchEventArgs args)
        {
            this.State = args.SwitchEnabled;
        }
    }
}
