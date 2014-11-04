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
        public void Blink(Robot robot)
        {
            while (!shouldStop)
            {
                bool ledEnabled = true;
                robot.RobotConsole[Leds.Led1].LedEnabled = ledEnabled;
                robot.RobotConsole[Leds.Led2].LedEnabled = ledEnabled;
                robot.RobotConsole[Leds.Led3].LedEnabled = ledEnabled;
                robot.RobotConsole[Leds.Led4].LedEnabled = ledEnabled;

                ledEnabled = !ledEnabled;
                Thread.Sleep(1000);
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
