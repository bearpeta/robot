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
    public partial class RunLineView : UserControl
    {
        public RunLineView()
        {
            InitializeComponent();
        }

        public Drive Drive { get; set; }

        public float Speed { get; set; }

        public float Acceleration { get; set; }

        private void button2_Click(object sender, EventArgs e)
        {
            Drive.RunLine(float.Parse(numericUpDownLength.Text)/1000, Speed, Acceleration);
        }
    }
}
