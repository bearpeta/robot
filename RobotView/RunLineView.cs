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
            this.Length = float.Parse(numericUpDownLength.Text) / 1000;
        }

        public Drive Drive { get; set; }

        public float Length { get; private set; }

        public float Speed { get; set; }

        public float Acceleration { get; set; }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Start();
        }

        public void Start()
        {
            Drive.RunLine(this.Length, Speed, Acceleration);
        }

        private void numericUpDownLength_ValueChanged(object sender, EventArgs e)
        {
            this.Length = float.Parse(numericUpDownLength.Text) / 1000;
        }
    }
}
