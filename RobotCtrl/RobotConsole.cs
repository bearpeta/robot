using System;

namespace Hslu.Csa.Team6.RobotCtrl
{
    /// <summary>
    /// Bildet die Konsole des Roboters ab, die aus den LED's und Schaltern besteht.
    /// </summary>
    public class RobotConsole : IDisposable
    {

        #region members
        private Led[] leds;
        private Switch[] switches;
        private DigitalIn digitalIn;
        private DigitalOut digitalOut;
        #endregion


        #region constructor & destructor
        /// <summary>
        /// Initialisiert die Roboter-Konsole mit den dazugehörigen LED's und Schalter.
        /// </summary>
        /// 
        /// <param name="runMode">Der gewünschte RunMode (Simulation oder Roboter)</param>
        public RobotConsole()
        {
            digitalIn = new DigitalIn(Constants.IOConsoleSWITCH);
            digitalOut = new DigitalOut(Constants.IOConsoleLED);


            this.leds = new Led[4];
            for (int i = 0; i < this.leds.Length; i++)
            {
                leds[i] = new Led(digitalOut, (Leds)i);
            }

            this.switches = new Switch[4];
            for (int i = 0; i < this.switches.Length; i++)
            {
                switches[i] = new Switch(digitalIn, (Switches)i);
            }

            this[Switches.Switch1].SwitchStateChanged += (sender, e) =>
            {
                this[Leds.Led1].LedEnabled = e.SwitchEnabled;
            };

            this[Switches.Switch2].SwitchStateChanged += (sender, e) =>
            {
                this[Leds.Led2].LedEnabled = e.SwitchEnabled;
            };

            this[Switches.Switch3].SwitchStateChanged += (sender, e) =>
            {
                this[Leds.Led3].LedEnabled = e.SwitchEnabled;
            };

            this[Switches.Switch4].SwitchStateChanged += (sender, e) =>
            {
                this[Leds.Led4].LedEnabled = e.SwitchEnabled;
            };
        }


        public void Dispose()
        {
            digitalIn.Dispose();
        }
        #endregion


        #region methods
        /// <summary>
        /// Zugriff auf die LED per Indexer
        /// </summary>
        /// <param name="led"></param>
        /// <returns></returns>
        public Led this[Leds led]
        {
            get { return this.leds[(int)led]; }
        }


        /// <summary>
        /// Zugriff auf die Schalter per Indexer
        /// </summary>
        /// <param name="swi"></param>
        /// <returns></returns>
        public Switch this[Switches swi]
        {
            get { return this.switches[(int)swi]; }
        }
        #endregion
    }


}
