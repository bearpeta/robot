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
    public partial class RunTurnView : UserControl
    {
        public RunTurnView()
        {
            InitializeComponent();
            this.Angle = float.Parse(numericUpDownAngle.Text);
        }

        public Drive Drive { get; set; }

        public float Angle { get; private set; }

        public float Speed { get; set; }

        public float Acceleration { get; set; }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.Start();
        }

        public void Start()
        {
            this.Drive.RunTurn(this.Angle, this.Speed, this.Acceleration);
        }

        private void numericUpDownAngle_ValueChanged(object sender, EventArgs e)
        {
            this.Angle = float.Parse(numericUpDownAngle.Text);
        }
    }
}
