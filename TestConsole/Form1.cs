using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hslu.Csa.Team6.RobotCtrl;

namespace Hslu.Csa.Team6.TestConsole
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.consoleView1.RobotConsole = new RobotConsole();
        }
    }
}