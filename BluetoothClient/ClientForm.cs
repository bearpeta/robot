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
        #region robotDictionary
        private Dictionary<String, String> robotDictionary = new Dictionary<string, string>()
            {
                {"HSLU_01","001BDC002157"},
                {"HSLU_02","001BDC0FFDEF"},
                {"HSLU_03","001BDC0021C4"},
                {"HSLU_04","001BDC0F8F39"},
                {"HSLU_05","001BDC00212A"},
                {"HSLU_06","001BDC0003CC"},
                {"HSLU_07","001BDC002140"},
                {"HSLU_08","001BDC0FFEDE"},
                {"HSLU_09","001BDC0FFE1C"},
                {"HSLU_10","001BDC000023"},
                {"HSLU_11","001BDC0021F1"},
                {"HSLU_12","001BDC002145"},
                {"HSLU_13","001BDC00034C"},
                {"HSLU_14","001BDC002139"},
                {"HSLU_15","001BDC0FF453"},
                {"HSLU_16","001BDC0022D5"},
                {"HSLU_17","001BDC0022D6"},
                {"HSLU_18","001BDC00202F"},
                {"HSLU_19","001BDC0FFDED"},
                {"HSLU_20","001BDC0FF360"},
                {"HSLU_21","001BDC0FE81D"},
                {"HSLU_25","000000000000"},
                {"HSLU_30","001BDC0021D1"}
            };
        #endregion 

        #region actions
        private String[] actions = new String[] { 
            "TrackLine ", 
            "TrackTurnLeft ", 
            "TrackTurnRight ", 
            "TrackArcLeft ", 
            "TrackArcRight " 
        };
        #endregion

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

            comboBoxRobots.DataSource = new BindingSource(robotDictionary, null);
            comboBoxRobots.DisplayMember = "Key";
            comboBoxRobots.ValueMember = "Value";

            foreach (String action in actions) {
                comboBoxActions.Items.Add(action);
            }
        }

        public String getSelectedRobotMAC() {
            return comboBoxRobots.SelectedValue.ToString();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            String action = comboBoxActions.SelectedItem.ToString();
            String angle = textBoxAngle.Text;
            String length = textBoxLength.Text;

            if(angle.Equals("")) {
                textBoxCommands.AppendText(action + length + Environment.NewLine);
            }
            else if (length.Equals(""))
            {
                textBoxCommands.AppendText(action + angle + Environment.NewLine);
            }
            else {
                textBoxCommands.AppendText(action + angle + " " + length + Environment.NewLine);
            } 
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            string[] lines = textBoxCommands.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

            foreach (String line in lines) {
                Console.WriteLine(line);
            }
        }
    }
}
