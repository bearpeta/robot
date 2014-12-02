using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Hslu.Csa.Team6.BluetoothServer;
using Hslu.Csa.Team6.RobotCtrl;

namespace Hslu.Csa.Team6.Testat2
{
    class Program
    {
        static void Main(string[] args)
        {
            Decoder d = new Decoder(new Robot());
            Server bs = new Server();
            bs.OnCommandsRecieved += d.CommandsRecieved;
            bs.Start();
        }
    }
}
