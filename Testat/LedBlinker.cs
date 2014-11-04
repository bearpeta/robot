using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Hslu.Csa.Team6.RobotCtrl;
using System.Threading;

namespace Hslu.Csa.Team6.Testat
{
    internal class LedBlinker
    {
        private Robot robot;

        public LedBlinker(Robot robot)
        {
            this.robot = robot;
        }

        public void Blink()
        {
            bool ledEnabled = true;

            while (!shouldStop)
            {
                Thread.Sleep(500);
                this.robot.RobotConsole[Leds.Led1].LedEnabled = ledEnabled;
                this.robot.RobotConsole[Leds.Led2].LedEnabled = ledEnabled;
                this.robot.RobotConsole[Leds.Led3].LedEnabled = ledEnabled;
                this.robot.RobotConsole[Leds.Led4].LedEnabled = ledEnabled;

                ledEnabled = !ledEnabled;
               
            }
            
            // Terminate Thread
        }

        public void RequestStop()
        {
            shouldStop = true;
        }

        private volatile bool shouldStop;
    }
}
