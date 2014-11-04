using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hslu.Csa.Team6.RobotCtrl;
using System.Threading;

namespace Hslu.Csa.Team6.Testat
{
    public partial class Form1 : Form
    {
        Robot robot = new Robot();
        bool isWorking = false;

        private const float speed = 0.5f;
        private  const float acceleration = 0.2f;

        public Form1()
        {
            this.InitializeComponent();
            this.robot.RobotConsole[Switches.Switch1].SwitchStateChanged += this.StartTestatProgram;
        }

        private void StartTestatProgram(object sender, SwitchEventArgs e)
        {
            bool start = false;

            lock (this)
            {
                if (!this.isWorking)
                {
                    this.isWorking = true;
                    start = true;
                }
            }

            if (start)
            {
                DistanceTracker dt = new DistanceTracker(this.robot, 20);


                const float length = 2.0f;
                const float width = 1.5f;

                // Blinken starten
                LedBlinker ledBlinker = new LedBlinker(this.robot);
                Thread ledThread = new Thread(ledBlinker.Blink);
                Thread distanceThread = new Thread(dt.Track);
                ledThread.Start();

                int status1 = robot.Drive.DriveInfo.DriveStatus;

                robot.Drive.Power = true;
                distanceThread.Start();

                for (int i = 0; i < 2; i++)
                {
                    this.RunLine(length);
                    dt.Checkpoint();

                    this.RunTurn();
                    dt.Checkpoint();

                    this.RunLine(width);
                    dt.Checkpoint();

                    this.RunTurn();
                    dt.Checkpoint();
                }

                dt.RequestStop();
                // Stop blinking
                ledBlinker.RequestStop();

                distanceThread.Join();
                ledThread.Join();

                float objectLength = length - dt.MinDistances[2] - dt.MinDistances[6];
                float objectWidth = width - dt.MinDistances[0] - dt.MinDistances[4];


                if (objectLength > objectWidth)
                {
                    robot.RobotConsole[Leds.Led1].LedEnabled = true;
                    robot.RobotConsole[Leds.Led2].LedEnabled = false;
                    robot.RobotConsole[Leds.Led3].LedEnabled = false;
                    robot.RobotConsole[Leds.Led4].LedEnabled = true;
                }
                else
                {
                    robot.RobotConsole[Leds.Led1].LedEnabled = false;
                    robot.RobotConsole[Leds.Led2].LedEnabled = true;
                    robot.RobotConsole[Leds.Led3].LedEnabled = true;
                    robot.RobotConsole[Leds.Led4].LedEnabled = false;
                }
            }

            lock (this)
            {
                this.isWorking = false;
            }
        }

        private void RunLine(float length)
        {
            this.robot.Drive.RunLine(length, speed, acceleration);
            while (!this.robot.Drive.Done) { }
        }

        private void RunTurn()
        {
            this.robot.Drive.RunTurn(88, speed, acceleration);
            while (!this.robot.Drive.Done) { }
        }
    }
}