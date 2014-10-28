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
            Robot robot = new Robot();

            InitializeComponent();
            runLineView1.Speed = commonRunParameters1.Speed;
            runLineView1.Acceleration = commonRunParameters1.Acceleration;
            runArcView1.Speed = commonRunParameters1.Speed;
            runArcView1.Acceleration = commonRunParameters1.Acceleration;
            runTurnView1.Speed = commonRunParameters1.Speed;
            runTurnView1.Acceleration = commonRunParameters1.Acceleration;

            robot.Drive.Power = true;

            runLineView1.Drive = robot.Drive;
            runArcView1.Drive = robot.Drive;
            runTurnView1.Drive = robot.Drive;
            driveView1.Drive = robot.Drive;

            robot.RobotConsole[Switches.Switch1].SwitchStateChanged += (sender,e) =>
            {
                runLineView1.Start();
            };

            robot.RobotConsole[Switches.Switch2].SwitchStateChanged += (sender, e) =>
            {
                runTurnView1.Start();
            };

            robot.RobotConsole[Switches.Switch3].SwitchStateChanged += (sender, e) =>
            {
                runArcView1.TurnLeft = true;
                runArcView1.Start();
            };

            robot.RobotConsole[Switches.Switch4].SwitchStateChanged += (sender, e) =>
            {
                runArcView1.TurnLeft = false;
                runArcView1.Start();
            };
        }

        private void commonRunParameters1_SpeedChanged(object sender, EventArgs e)
        {
            runLineView1.Speed = commonRunParameters1.Speed;
            runTurnView1.Speed = commonRunParameters1.Speed;
            runArcView1.Speed = commonRunParameters1.Speed;
        }

        private void commonRunParameters1_AccelerationChanged(object sender, EventArgs e)
        {
            runLineView1.Acceleration = commonRunParameters1.Acceleration;
            runTurnView1.Acceleration = commonRunParameters1.Acceleration;
            runArcView1.Acceleration = commonRunParameters1.Acceleration;
        }
    }
}