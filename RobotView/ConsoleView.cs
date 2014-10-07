using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Hslu.Csa.Team6.RobotCtrl;

namespace Hslu.Csa.Team6.RobotView
{
    public partial class ConsoleView : UserControl
    {
        private RobotConsole robotConsole;

        public ConsoleView()
        {
            InitializeComponent();
        }

        public RobotConsole RobotConsole
        {
            get
            {
                return this.robotConsole;
            }
            set
            {
                this.robotConsole = value;
                if (this.robotConsole != null)
                {
                    ledView0.Led = this.robotConsole[Leds.Led1];
                    ledView1.Led = this.robotConsole[Leds.Led2];
                    ledView2.Led = this.robotConsole[Leds.Led3];
                    ledView3.Led = this.robotConsole[Leds.Led4];
                    switchView0.Switch = this.robotConsole[Switches.Switch1];
                    switchView1.Switch = this.robotConsole[Switches.Switch2];
                    switchView2.Switch = this.robotConsole[Switches.Switch3];
                    switchView3.Switch = this.robotConsole[Switches.Switch4];



                    this.robotConsole[Switches.Switch1].SwitchStateChanged += (sender, e) =>
                    {
                        this.robotConsole[Leds.Led1].LedEnabled = e.SwitchEnabled;
                    };

                    this.robotConsole[Switches.Switch2].SwitchStateChanged += (sender, e) =>
                    {
                        this.robotConsole[Leds.Led2].LedEnabled = e.SwitchEnabled;
                    };

                    this.robotConsole[Switches.Switch3].SwitchStateChanged += (sender, e) =>
                    {
                        this.robotConsole[Leds.Led3].LedEnabled = e.SwitchEnabled;
                    };

                    this.robotConsole[Switches.Switch4].SwitchStateChanged += (sender, e) =>
                    {
                        this.robotConsole[Leds.Led4].LedEnabled = e.SwitchEnabled;
                    };
                }
            }
        }
    }
}
