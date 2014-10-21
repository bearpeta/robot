using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hslu.Csa.Team6.RobotCtrl;

namespace Hslu.Csa.Team6.TestMotor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DriveCtrl driveCtrl = new DriveCtrl(Constants.IODriveCtrl);
            MotorCtrl motorCtrlLeft = new MotorCtrl(Constants.IOMotorCtrlLeft);
            MotorCtrl motorCtrlRight = new MotorCtrl(Constants.IOMotorCtrlRight);

            driveCtrlView1.DriveCtrl = driveCtrl;
            motorCtrlViewLeft.MotorCtrl = motorCtrlLeft;
            motorCtrlViewRight.MotorCtrl = motorCtrlRight;

        }
    }
}