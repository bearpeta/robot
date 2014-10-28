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
            this.Radius = float.Parse(numericUpDownRadius.Text) / 1000;
            this.Angle = float.Parse(numericUpDownAngle.Text);
            this.TurnLeft = radioButtonLeft.Checked;
        }

        public Drive Drive { get; set; }

        public bool TurnLeft { get; set; }

        public float Angle { get; private set; }

        public float Radius { get; private set; }

        public float Speed { get; set; }

        public float Acceleration { get; set; }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.Start();
        }

        public void Start()
        {
            if (this.TurnLeft)
            {
                this.Drive.RunArcLeft(this.Radius, this.Angle, this.Speed, this.Acceleration);
            }
            else
            {
                this.Drive.RunArcRight(this.Radius, this.Angle, this.Speed, this.Acceleration);
            }

        }

        private void numericUpDownRadius_ValueChanged(object sender, EventArgs e)
        {
            this.Radius = float.Parse(numericUpDownRadius.Text) / 1000;
        }

        private void numericUpDownAngle_ValueChanged(object sender, EventArgs e)
        {
            this.Angle = float.Parse(numericUpDownAngle.Text);
        }

        private void radioButtonLeft_CheckedChanged(object sender, EventArgs e)
        {
            this.TurnLeft = radioButtonLeft.Checked;
        }
    }
}
