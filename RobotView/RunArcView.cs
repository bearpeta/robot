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
    public partial class RunArcView : UserControl
    {
        public RunArcView()
        {
            InitializeComponent();
        }

        public Drive Drive { get; set; }

        public float Speed { get; set; }

        public float Acceleration { get; set; }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if(radioButtonLeft.Checked){
                this.Drive.RunArcLeft(float.Parse(numericUpDownRadius.Text)/1000, float.Parse(numericUpDownAngle.Text), this.Speed, this.Acceleration);
            }

            else if (radioButtonRight.Checked) {
                this.Drive.RunArcRight(float.Parse(numericUpDownRadius.Text)/1000, float.Parse(numericUpDownAngle.Text), this.Speed, this.Acceleration);
            }
           
        }
    }
}
