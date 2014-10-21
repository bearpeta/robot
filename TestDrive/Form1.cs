using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hslu.Csa.Team6.RobotCtrl;

namespace Hslu.Csa.Team6.TestDrive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            runLineView1.Speed = commonRunParameters1.Speed;
            runLineView1.Acceleration = commonRunParameters1.Acceleration;
            Drive drive = new Drive();
            drive.Power = true;
            
            runLineView1.Drive = drive;
            driveView1.Drive = drive;
        }

        private void commonRunParameters1_SpeedChanged(object sender, EventArgs e)
        {
            runLineView1.Speed = commonRunParameters1.Speed;
        }

        private void commonRunParameters1_AccelerationChanged(object sender, EventArgs e)
        {
            runLineView1.Acceleration = commonRunParameters1.Acceleration;
        }
    }
}