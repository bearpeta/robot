using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Hslu.Csa.Team6.RobotCtrl
{
    public struct PositionInfo
    {
        public float X;
        public float Y;
        public float Angle;

        public PositionInfo(float x, float y, float angle)
        {
            X = x;
            Y = y;
            Angle = angle;
        }
    }
}
