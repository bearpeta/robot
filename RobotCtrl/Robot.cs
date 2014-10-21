using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Hslu.Csa.Team6.RobotCtrl
{
    public class Robot: IDisposable
    {

        #region members
        private RobotConsole robotConsole;
        //private Radar radar;
        private Drive drive;
        #endregion


        #region constructor & destructor
        public Robot()
        {
            this.robotConsole = new RobotConsole();
           // this.radar = new Radar(Constants.IORadarSensor);
            this.drive = new Drive();
        }

        /// <summary>
        /// Disposed das Drive-Objekt sowie die robotConsole.
        /// Damit werden die Worker-Threads in diesen Objekten beendet
        /// </summary>
        public void Dispose()
        {
            this.drive.Dispose();
            this.robotConsole.Dispose();
        }
        #endregion


        #region properties
        /// <summary>
        /// Liefert die Konsole des Roboters
        /// </summary>
        public RobotConsole RobotConsole
        {
            get { return this.robotConsole; }
        }


        /// <summary>
        /// Liefert den Radar des Roboters
        /// </summary>
        //public Radar Radar
        //{
        //    get { return this.radar; }
        //}


        /// <summary>
        /// Liefert den Antrieb des Roboters
        /// </summary>
        public Drive Drive
        {
            get { return this.drive; }
        }


        /// <summary>
        /// Liefert bzw. setzt die aktuelle Postion des Roboters.
        /// </summary>
        public PositionInfo Position { get { return drive.Position; } set { drive.Position = value; } }
        #endregion
    }
}
