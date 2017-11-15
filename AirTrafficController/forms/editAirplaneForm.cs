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

            loadMinMaxValues();
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
            numericUpDown_airplaneSpeed.Value = (decimal)random.Next(Game1.minMaxMAXSpeed[0], Game1.minMaxMAXSpeed[1]);
            numericUpDown_airplaneMaxSpeed.Value = (decimal)random.Next(Game1.minMaxMAXSpeed[0], Game1.minMaxMAXSpeed[1]);
            numericUpDown_airplaneAcceleration.Value = (decimal)random.Next(Game1.minMaxAcceleration[0], Game1.minMaxAcceleration[0]);
            numericUpDown_airplaneVerticalAcceleration.Value = (decimal)random.Next(Game1.minMaxVerticalAcceleration[0], Game1.minMaxVerticalAcceleration[1]);
            numericUpDown_airplaneAltitude.Value = (decimal)random.Next(Game1.minMaxAltitude[0], Game1.minMaxAltitude[1]);
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

        private void loadSelectedAirplaneInfo()
        {
            textBox_airplaneId.Text = this.selectedAirplane.getId();
            textBox_airplaneVendor.Text = this.selectedAirplane.getVendor();
            textBox_airplaneModel.Text = this.selectedAirplane.getModel();
            numericUpDown_airplaneCapacity.Value = this.selectedAirplane.getCapacity();
            numericUpDown_airplaneAcceleration.Value = this.selectedAirplane.getAcceleration();
            numericUpDown_airplaneVerticalAcceleration.Value = this.selectedAirplane.getVerticalAcceleration();
            numericUpDown_airplaneAltitude.Value = this.selectedAirplane.getAltitude();
            numericUpDown_airplaneCoordinateX.Value = (decimal)this.selectedAirplane.getPos().X;
            numericUpDown_airplaneCoordinateY.Value = (decimal)this.selectedAirplane.getPos().Y;
            numericUpDown_airplaneCapacity.Value = this.selectedAirplane.getCapacity();
            numericUpDown_airplaneSpeed.Value = this.selectedAirplane.getSpeed();
            numericUpDown_airplaneMaxSpeed.Value = this.selectedAirplane.getMaxSpeed();

            //Direction
            switch (utilVector2.getStringFromDirection(this.selectedAirplane.getDirection()))
            {
                case "Left":
                    this.radioButton_airplaneDirectionLeft.Checked = true;
                    break;
                case "Right":
                    this.radioButton_airplaneDirectionRight.Checked = true;
                    break;
                case "Up":
                    this.radioButton_airplaneDirectionUp.Checked = true;
                    break;
                case "Down":
                    this.radioButton_airplaneDirectionDown.Checked = true;
                    break;
            }
        }

        private void button_saveAirplane_Click(object sender, EventArgs e)
        {
            if (!checkFields()) { return; }
            this.loadValuesToSelectedAirplane();
        }

        private void loadValuesToSelectedAirplane()
        {
            Vector2 chosenDirection = utilVector2.getDirectionFromString(checkedRadioButtonDirection().Text);
            this.selectedAirplane.Initialize(
                textBox_airplaneId.Text,
                game.icons.ElementAt(0).Value,
                textBox_airplaneVendor.Text,
                textBox_airplaneModel.Text,
                new Vector2((float)numericUpDown_airplaneCoordinateX.Value, (float)numericUpDown_airplaneCoordinateY.Value),
                chosenDirection,
                (int)numericUpDown_airplaneAltitude.Value,
                (int)numericUpDown_airplaneSpeed.Value,
                (int)numericUpDown_airplaneMaxSpeed.Value,
                (int)numericUpDown_airplaneAcceleration.Value,
                (int)numericUpDown_airplaneVerticalAcceleration.Value,
                100
            );
        }

        private void loadMinMaxValues()
        {
            //This functions makes sure every form has the same limits on numericupdown values

            //Numeric updown maximum number depending on the map size
            numericUpDown_airplaneCoordinateX.Maximum = (Decimal)game.getMapSize().X;
            numericUpDown_airplaneCoordinateY.Maximum = (Decimal)game.getMapSize().Y;

            numericUpDown_airplaneCapacity.Minimum = Game1.minMaxCapacity[0];
            numericUpDown_airplaneCapacity.Maximum = Game1.minMaxCapacity[1];

            numericUpDown_airplaneAcceleration.Minimum = Game1.minMaxAcceleration[0];
            numericUpDown_airplaneAcceleration.Maximum = Game1.minMaxAcceleration[1];

            numericUpDown_airplaneVerticalAcceleration.Minimum = Game1.minMaxVerticalAcceleration[0];
            numericUpDown_airplaneVerticalAcceleration.Maximum = Game1.minMaxVerticalAcceleration[1];

            numericUpDown_airplaneAltitude.Minimum = Game1.minMaxAltitude[0];
            numericUpDown_airplaneAltitude.Maximum = Game1.minMaxAltitude[1];

            numericUpDown_airplaneCapacity.Minimum = Game1.minMaxCapacity[0];
            numericUpDown_airplaneCapacity.Maximum = Game1.minMaxCapacity[1];

            numericUpDown_airplaneMaxSpeed.Minimum = Game1.minMaxMAXSpeed[0];
            numericUpDown_airplaneMaxSpeed.Maximum = Game1.minMaxMAXSpeed[1];

            numericUpDown_airplaneSpeed.Minimum = Game1.minMaxMAXSpeed[0];
            numericUpDown_airplaneSpeed.Maximum = Game1.minMaxMAXSpeed[1];
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

        private void button_airplaneRemove_Click(object sender, EventArgs e)
        {
            this.game.removeAirplane(this.selectedAirplane);
            this.Close();
        }
    }
}
