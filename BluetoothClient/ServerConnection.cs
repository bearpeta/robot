using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TA.Bluetooth;
using System.IO;

namespace Hslu.Csa.Team6.BluetoothClient
{
    internal class ServerConnection
    {
        private string macAddress;

        public ServerConnection(string macAddress)
        {
            this.macAddress = macAddress;
        }

        public void SendCommands(IEnumerable<string> commands)
        {
            if (commands == null)
            {
                throw new ArgumentNullException("commands");
            }

            if (commands.Count() <= 0)
            {
                throw new ArgumentException("commands cannot be empty!");
            }

            Console.WriteLine("Search for device " + this.macAddress + "...");
            // desired service
            Guid service = BluetoothServiceList.Robot20;
            try
            {

                TA.Bluetooth.BluetoothClient bc = BluetoothDevice.Connect(this.macAddress, service);
                if (bc != null)
                {
                    Console.WriteLine("Outgoing connection " + bc.GetSocket().LocalEndPoint + ".");
                    // read transmitted data
                    StreamReader sr = new StreamReader(bc.GetStream());
                    StreamWriter sw = new StreamWriter(bc.GetStream());
                    // request

                    foreach (string command in commands)
                    {
                        sw.WriteLine(command);
                    }
                    sw.Flush();

                    // print 
                    //Console.WriteLine("Message received : ");
                    Console.WriteLine(sr.ReadLine());
                    bc.Close();
                }
                else
                {
                    Console.WriteLine("Target does not exist");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
