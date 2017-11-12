using AirTrafficController.util;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace AirTrafficController.forms
{
    public partial class controllerAirplaneForm : Form
    {
        Game1 game;
        private List<iAirplane> availableAirplanes = new List<iAirplane>();
        private iAirplane selectedAirplane;
        private Timer timerLiveVariables; 
        public controllerAirplaneForm()
        {
        }
        public controllerAirplaneForm(Game1 game)
        {
            InitializeComponent();

            timerLiveVariables = new Timer();
            timerLiveVariables.Tick += new EventHandler(this.loadLiveVariables);
            timerLiveVariables.Interval = 200;
            timerLiveVariables.Start();

            this.game = game;
        }
        private void loadAvailableAirplanes()
        {
            this.availableAirplanes.Clear();
            this.availableAirplanes = this.game.getMap().getAirplanes();

            DataTable tmp_dt = new DataTable();
            tmp_dt.Clear();
            tmp_dt.Columns.Add("name", typeof(String));
            tmp_dt.Columns.Add("iAirplane", typeof(iAirplane));

            foreach (iAirplane airplane in this.availableAirplanes)
            {
                DataRow hashTypeRow = tmp_dt.NewRow();
                hashTypeRow["name"] = airplane.getId() + " - " + airplane.getVendor() + " - " + airplane.getModel();
                hashTypeRow["iAirplane"] = airplane;
                tmp_dt.Rows.Add(hashTypeRow);
            }


            //Reset items from combobox
            comboBox_availableAirplanes.Items.Clear();

            comboBox_availableAirplanes.ValueMember = "iAirplane";
            comboBox_availableAirplanes.DisplayMember = "name";
            comboBox_availableAirplanes.DataSource = tmp_dt;
        }

        private void comboBox_airplanePresets_SelectedValueChanged(object sender, EventArgs e)
        {
            //Load preset into form
            DataRowView selectedValueRow = (DataRowView)comboBox_availableAirplanes.SelectedItem;
            if(selectedValueRow == null) { return; }
            iAirplane airplane = (iAirplane)selectedValueRow[1];
            this.selectedAirplane = airplane;
            this.loadSelectedAirplaneInfo();
        }
        private void loadLiveVariables(Object o, EventArgs e)
        {
            if(this.selectedAirplane == null) { return; }
            if (!this.game.getMap().existIdInMap(this.selectedAirplane.getId()))
            {
                this.Close();
                return;
            }
            this.label_airplaneAltitude.Text = this.selectedAirplane.getAltitude().ToString();
            this.label_airplaneAcceleration.Text = this.selectedAirplane.getAcceleration().ToString();
            this.label_airplaneSpeed.Text = this.selectedAirplane.getSpeed().ToString();
            this.label_airplaneCollisionDanger.Text = this.selectedAirplane.getCollisionDanger().ToString();
            this.label_airplaneMotorStatus.Text = this.selectedAirplane.getIsOn().ToString();
            this.label_airplaneAltitudeDanger.Text = this.selectedAirplane.getAltitudeDanger().ToString();
            this.label_airplaneLandingGear.Text = this.selectedAirplane.getDeployedLandingGear().ToString();
        }
        private void loadSelectedAirplaneInfo()
        {
            textBox_airplaneId.Text = this.selectedAirplane.getId();
        }
        private void button_airplaneSwitchMotorStatus_Click(object sender, EventArgs e)
        {
            this.selectedAirplane.switchIsOn();
        }

        private void button_airplaneSwitchDeployedLandingGear_Click(object sender, EventArgs e)
        {
            this.selectedAirplane.switchDeployedLandingGear();
        }

        private void button_airplaneAscend_Click(object sender, EventArgs e)
        {
            this.selectedAirplane.setVerticalAcceleration(Game1.minMaxVerticalAcceleration[1]);
        }

        private void button_airplaneDescend_Click(object sender, EventArgs e)
        {
            this.selectedAirplane.setVerticalAcceleration(Game1.minMaxVerticalAcceleration[0]);
        }

        private void controllerAirplaneForm_Load(object sender, EventArgs e)
        {
            loadAvailableAirplanes();
        }

        private void button_airplaneAccelerate_Click(object sender, EventArgs e)
        {
            this.selectedAirplane.setAcceleration(this.selectedAirplane.getAcceleration() + 1);
        }

        private void button_airplaneBrake_Click(object sender, EventArgs e)
        {
            this.selectedAirplane.setAcceleration(this.selectedAirplane.getAcceleration() - 1);
        }

        private void controllerAirplaneForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.timerLiveVariables.Stop();
            this.timerLiveVariables.Dispose();
        }
    }
}
