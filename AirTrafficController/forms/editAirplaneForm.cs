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
/*
 *  Ens permetrà donar d’alta un avió al sistema. Caldrà que per teclat se’ns demanin les
 *  dades principals de l’avió “Model”, “fabricant”, “Capacitat” al igual que la posició inicial “x”, “y” i la
 *  “Matricula”.
*/
namespace AirTrafficController.forms
{
    public partial class editAirplaneForm : Form
    {
        Game1 game;
        private List<iAirplane> availableAirplanes = new List<iAirplane>();
        private iAirplane selectedAirplane;
        public editAirplaneForm()
        {
        }
        public editAirplaneForm(Game1 game)
        {
            InitializeComponent();
            this.game = game;

            //Numeric updown maximum number depending on the map size
            numericUpDown_airplaneCoordinateX.Maximum = (Decimal)game.getMapSize().X;
            numericUpDown_airplaneCoordinateY.Maximum = (Decimal)game.getMapSize().Y;

            loadAvailableAirplanes();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private RadioButton checkedRadioButtonDirection()
        {
            //SOURCE: https://stackoverflow.com/a/1798011/6832219
            foreach (var control in this.Controls)
            {
                RadioButton radio = control as RadioButton;

                if (radio != null && radio.Checked)
                {
                    return radio;
                }
            }

            return null;
        }
        private Boolean checkFields()
        {
            Boolean everythingOk = true;
            if (textBox_airplaneId.Text == "")
            {
                highlightWrongField(textBox_airplaneId);
                everythingOk = false;
            }
            if (textBox_airplaneModel.Text == "")
            {
                highlightWrongField(textBox_airplaneModel);
                everythingOk = false;
            }
            if (textBox_airplaneVendor.Text == "")
            {
                highlightWrongField(textBox_airplaneVendor);
                everythingOk = false;
            }

            return everythingOk;
        }
        private void highlightWrongField(TextBox textBox)
        {
            textBox.BackColor = System.Drawing.Color.Red;
        }

        private void button_randomNumbers_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            numericUpDown_airplaneCoordinateX.Value = (decimal)random.Next(1, (int)game.getMapSize().X);
            numericUpDown_airplaneCoordinateY.Value = (decimal)random.Next(1, (int)game.getMapSize().Y);
            numericUpDown_airplaneSpeed.Value = (decimal)random.Next(1, 50);
            numericUpDown_airplaneAcceleration.Value = (decimal)random.Next(1, 5);
            numericUpDown_airplaneAltitude.Value = (decimal)random.Next(1, 10000);
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
                hashTypeRow["name"] = airplane.getVendor() + " - " + airplane.getModel();
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

        private void loadSelectedAirplaneInfo()
        {
            textBox_airplaneId.Text = this.selectedAirplane.getId();
            textBox_airplaneVendor.Text = this.selectedAirplane.getVendor();
            textBox_airplaneModel.Text = this.selectedAirplane.getModel();
            numericUpDown_airplaneCapacity.Value = this.selectedAirplane.getCapacity();
            numericUpDown_airplaneAcceleration.Value = this.selectedAirplane.getAcceleration();
            numericUpDown_airplaneAltitude.Value = this.selectedAirplane.getAltitude();
            numericUpDown_airplaneCoordinateX.Value = (decimal)this.selectedAirplane.getPos().X;
            numericUpDown_airplaneCoordinateY.Value = (decimal)this.selectedAirplane.getPos().Y;
            numericUpDown_airplaneCapacity.Value = this.selectedAirplane.getCapacity();
            numericUpDown_airplaneMaxSpeed.Value = this.selectedAirplane.getMaxSpeed();
        }

        private void button_randomAirplaneId_Click(object sender, EventArgs e)
        {
            textBox_airplaneId.Text = game.generateRandomId();
        }

        private void button_saveAirplane_Click(object sender, EventArgs e)
        {
            if (!checkFields()) { return; }
            
        }
    }
}
