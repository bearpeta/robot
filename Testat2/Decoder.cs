using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Hslu.Csa.Team6.BluetoothServer;
using Hslu.Csa.Team6.RobotCtrl;

namespace Hslu.Csa.Team6.Testat2
{
    class Decoder
    {
        private const string TrackLine = "TrackLine";
        private const string TrackTurnLeft = "TrackTurnLeft";
        private const string TrackTurnRight = "TrackTurnRight";
        private const string TrackArcLeft = "TrackArcLeft";
        private const string TrackArcRight = "TrackArcRight";

        private const float Acceleration = 0.3F;
        private const float Speed = 0.5F;

        public Decoder(Robot robot)
        {
            this.Robot = robot;
        }

        public Robot Robot { get; private set; }

        public void CommandsRecieved(object sender, CommandsRecievedEventArgs e)
        {
            foreach (string command in e.Commands)
            {
                Console.WriteLine("Decoder:" + command);

                string[] commandParts = command.Split(' ');

                switch (commandParts[0])
                {
                    case TrackLine:
                        {
                            Robot.Drive.RunLine(1, Speed, Acceleration);
                            break;
                        }
                    case TrackTurnRight:
                        {
                            break;
                        }
                    case TrackTurnLeft:
                        {
                            break;
                        }
                    case TrackArcLeft:
                        {
                            break;
                        }
                    case TrackArcRight:
                        {
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Unknown command: " + command);
                            break;
                        }
                }

            }
        }
    }
}
