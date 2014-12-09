using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using TA.Bluetooth;
using System.IO;

namespace Hslu.Csa.Team6.BluetoothServer
{
    public class Server
    {
        public event EventHandler<CommandsRecievedEventArgs> OnCommandsRecieved;

        public Server()
        {
        }

        public void Start()
        {
            // check if Bluetooth-Stick is available
            if (BluetoothRadio.IsSupported)
            {
                // referenc to the primary Bluetooth-Stick 
                BluetoothRadio radio = BluetoothRadio.PrimaryRadio;
                Console.WriteLine("My Bluetooth-Stick:");
                // Bluetooth radio attributes
                Console.WriteLine("Name: " + radio.Name);
                Console.WriteLine("Mac:  " + radio.LocalAddressToString);
                Console.WriteLine("Mode: " + radio.Mode);

                BluetoothService service;

                // Device visible for others
                // RadioMode setting not supported as long as the
                // WinCE image doesn't include the BthUtil.dll
                // BluetoothRadio.PrimaryRadio.Mode = 
                //     BluetoothRadioMode.Discoverable;

                // set device Name
                BluetoothRadio.PrimaryRadio.Name = "Team 6 Robot";
                // desired service
                Guid serviceId = BluetoothServiceList.Robot20;
                // start new service
                service = new BluetoothService();
                service.CreateService(serviceId);
                Console.WriteLine("Service " + serviceId.ToString() + " started.");

                BluetoothClient client;

                while (true)
                {
                    Console.WriteLine("wait for incoming connections...");

                    // accept bluetooth connection
                    client = service.WaitForConnection();
                    Console.WriteLine("Incoming connection " + client.GetSocket().RemoteEndPoint);

                    // transform into network stream
                    using (System.Net.Sockets.NetworkStream ns = client.GetStream())
                    {
                        // Output data to stream
                        StreamReader sr = new StreamReader(ns);
                        StreamWriter sw = new StreamWriter(ns);

                        List<string> commands = new List<string>();

                        while (!sr.EndOfStream)
                        {
                            string command = sr.ReadLine();
                            if (command.Equals("Start", StringComparison.InvariantCultureIgnoreCase))
                            {
                                sw.WriteLine("Commands recieved.");
                                this.OnCommandsRecieved(this, new CommandsRecievedEventArgs(commands));
                                commands = new List<string>();
                                sw.Flush();
                            }
                            else
                            {
                                commands.Add(command);
                            }
                        }

                        sw.Flush();
                        client.Close();
                    }
                }
            }
            else
            {
                Console.WriteLine("No Bluetooth-Stick is available");
            }
        }
    }
}
