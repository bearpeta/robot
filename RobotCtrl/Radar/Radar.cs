using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Hslu.Csa.Team6.RobotCtrl
{
    public class Radar
    {

        #region members
        private int ioAddress;
        #endregion


        #region constructor & destructor
        public Radar(int IOAddress)
		{
            ioAddress = IOAddress;
        }
        #endregion


        #region properties
        /// <summary>
        /// Liefert die gemessene Distanz zum nächsten Objekt [m]
        /// </summary>
        public float Distance { get { return IOPort.Read(ioAddress) / 100.0f; } }
        #endregion

    }
}
