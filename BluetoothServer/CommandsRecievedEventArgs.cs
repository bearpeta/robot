using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Hslu.Csa.Team6.BluetoothServer
{
    public class CommandsRecievedEventArgs : EventArgs
    {
        public CommandsRecievedEventArgs(IList<string> commands)
        {
            this.Commands = commands;
        }

        public IList<string> Commands { get; private set; }
    }
}
