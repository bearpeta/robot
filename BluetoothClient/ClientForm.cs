using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TA.Bluetooth;

namespace Hslu.Csa.Team6.BluetoothClient
{
    public partial class ClientForm : Form
    {
        public ClientForm()
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
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("No Bluetooth-Stick is available");
            }

            InitializeComponent();
        }
    }
}
