using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Hslu.Csa.Team6.RobotCtrl;
using System.Threading;

namespace Hslu.Csa.Team6.Testat
{
    internal class DistanceTracker
    {
        private Robot robot;

        public DistanceTracker(Robot robot, int checkPoints)
        {
            this.robot = robot;
            this.MinDistances = new float[checkPoints];
        }

        public float[] MinDistances { get; private set; }

        public void Track()
        {
            this.MinDistances[0] = float.MaxValue;

            while (!shouldStop)
            {
                lock (this)
                {
                    float distance = this.robot.Radar.Distance;
                    if (distance < this.MinDistances[this.index])
                    {
                        this.MinDistances[this.index] = distance;
                    }
                }

                Thread.Sleep(50);
            }
        }

        public void RequestStop()
        {
            shouldStop = true;
        }

        public void Checkpoint()
        {
            lock (this)
            {
                this.index++;
                this.MinDistances[this.index] = float.MaxValue;
            }
        }

        private volatile int index;
        private volatile bool shouldStop;
    }
}
