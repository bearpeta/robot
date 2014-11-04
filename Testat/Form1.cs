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
                // Blinken starten
                LedBlinker ledBlinker = new LedBlinker(this.robot);
                Thread ledThread = new Thread(ledBlinker.Blink);
                ledThread.Start();
                while (!ledThread.IsAlive) ;

                Thread.Sleep(10000);

                // Stop blinking
                ledBlinker.RequestStop();
                ledThread.Join();
            }

            lock (this)
            {
                this.isWorking = false;
            }
        }
    }
}