using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Hslu.Csa.Team6.BluetoothServer;
using Hslu.Csa.Team6.RobotCtrl;
using System.Threading;
using System.IO;

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

        private IList<string> logs;

        public void CommandsRecieved(object sender, CommandsRecievedEventArgs e)
        {
            logs = new List<string>();

            logs.Add("Start Exec " + DateTime.Now.ToShortDateString());

            foreach (string command in e.Commands)
            {
                logs.Add("--------------------------------------------------------");
                logs.Add("Command: " + command);
                Console.WriteLine("Command: " + command);
                logs.Add("--------------------------------------------------------");

                string[] commandParts = command.Split(' ');

                this.Robot.Drive.Power = true;

                switch (commandParts[0])
                {
                    case TrackLine:
                        {
                            this.Robot.Drive.RunLine(this.GetFloatParam(commandParts), Speed, Acceleration);
                            this.WaitForDrive();
                            break;
                        }
                    case TrackTurnRight:
                        {
                            this.Robot.Drive.RunTurn(-this.GetIntParam(commandParts), Speed, Acceleration);
                            this.WaitForDrive();
                            break;
                        }
                    case TrackTurnLeft:
                        {
                            this.Robot.Drive.RunTurn(this.GetIntParam(commandParts), Speed, Acceleration);
                            this.WaitForDrive();
                            break;
                        }
                    case TrackArcLeft:
                        {
                            ParamTuple<int, float> parameters = this.GetTwoParams(commandParts);
                            this.Robot.Drive.RunArcLeft(parameters.Second, parameters.First, Speed, Acceleration);
                            this.WaitForDrive();
                            break;
                        }
                    case TrackArcRight:
                        {
                            ParamTuple<int, float> parameters = this.GetTwoParams(commandParts);
                            this.Robot.Drive.RunArcRight(parameters.Second, parameters.First, Speed, Acceleration);
                            this.WaitForDrive();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Unknown command: " + command);
                            break;
                        }
                }
            }

            logs.Add("--------------------------------------------------------");
            logs.Add("Execution Done");

            Console.WriteLine("Write File");

            this.WriteFile();
        }

        private void WriteFile()
        {
            using (FileStream fs = new FileStream(@"\CompactFlash\FtpRoot\Execution.txt", FileMode.OpenOrCreate, FileAccess.Write))
            using (StreamWriter sw = new StreamWriter(fs))
            {
                foreach (string log in logs)
                {
                    sw.WriteLine(log);
                }
            }
        }

        private ParamTuple<int, float> GetTwoParams(string[] commandParts)
        {
            if (commandParts.Length < 3)
            {
                throw new ArgumentException("Three command parts are required.");
            }

            int angle = int.Parse(commandParts[1]);
            float length = float.Parse(commandParts[2]);
            return new ParamTuple<int, float>(angle, length);
        }

        private int GetIntParam(string[] commandParts)
        {
            if (commandParts.Length < 2)
            {
                throw new ArgumentException("Two command parts are required.");
            }

            return int.Parse(commandParts[1]);
        }

        private float GetFloatParam(string[] commandParts)
        {
            if (commandParts.Length < 2)
            {
                throw new ArgumentException("Two command parts are required.");
            }

            return float.Parse(commandParts[1]);
        }

        private void WaitForDrive()
        {
            while (!this.Robot.Drive.Done)
            {
                this.LogPosition();
                Thread.Sleep(100);
            }
        }

        private void LogPosition()
        {
            logs.Add(string.Format("X: {0}, Y: {1}", this.Robot.Position.X, this.Robot.Position.Y));
        }

        private class ParamTuple<T1, T2>
        {
            public T1 First { get; private set; }
            public T2 Second { get; private set; }
            internal ParamTuple(T1 first, T2 second)
            {
                First = first;
                Second = second;
            }
        }
    }
}
