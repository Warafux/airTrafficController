using AirTrafficController.util;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
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
    public partial class newAirplaneForm : Form
    {
        Game1 game;
        private List<iAirplanePreset> airplanePresets = new List<iAirplanePreset>();
        private Dictionary<string, Texture2D> icons = new Dictionary<string, Texture2D>();
        private Texture2D selectedAirplaneIcon;

        public newAirplaneForm()
        {
        }
        public newAirplaneForm(Game1 game)
        {
            InitializeComponent();
            this.game = game;

            loadMinMaxValues();
            loadAirplanePresets();
            loadAirplaneIcons();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_addAirplane_Click(object sender, EventArgs e)
        {
            if (!checkFields()) { return; }
            map gameMap = game.getMap();
            airplane airplane = new airplane(gameMap);

            Vector2 chosenDirection = checkedRadioButtonDirection().Text == "Random Direction" ? utilVector2.getRandomDirection() : utilVector2.getDirectionFromString(checkedRadioButtonDirection().Text);
            airplane.Initialize(
                textBox_airplaneId.Text,
                selectedAirplaneIcon,
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

            this.game.addAirplaneToMap(airplane);
            this.Close();
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
            numericUpDown_airplaneAcceleration.Value = (decimal)random.Next(Game1.minMaxAcceleration[0], Game1.minMaxAcceleration[1]);
            numericUpDown_airplaneVerticalAcceleration.Value = (decimal)random.Next(Game1.minMaxVerticalAcceleration[0], Game1.minMaxVerticalAcceleration[1]);
            numericUpDown_airplaneAltitude.Value = (decimal)random.Next(Game1.minMaxAltitude[0], Game1.minMaxAltitude[1]);
        }

        private void loadAirplanePresets()
        {
            //Take presets from game main class
            airplanePresets.Clear();
            airplanePresets = game.airplanePresets;

            DataTable tmp_dt = new DataTable();
            tmp_dt.Clear();
            tmp_dt.Columns.Add("name", typeof(String));
            tmp_dt.Columns.Add("airplanePreset", typeof(iAirplanePreset));

            foreach (iAirplanePreset airplanePreset in this.airplanePresets)
            {
                DataRow hashTypeRow = tmp_dt.NewRow();
                hashTypeRow["name"] = airplanePreset.getVendor() + " - " + airplanePreset.getModel();
                hashTypeRow["airplanePreset"] = airplanePreset;
                tmp_dt.Rows.Add(hashTypeRow);
            }


            //Reset items from combobox
            comboBox_airplanePresets.Items.Clear();

            comboBox_airplanePresets.ValueMember = "airplanePreset";
            comboBox_airplanePresets.DisplayMember = "name";
            comboBox_airplanePresets.DataSource = tmp_dt;
        }
        private void loadAirplaneIcons()
        {
            //Take icons from game main class
            this.icons.Clear();
            this.icons = this.game.icons;

            DataTable tmp_dt = new DataTable();
            tmp_dt.Clear();
            tmp_dt.Columns.Add("name", typeof(String));
            tmp_dt.Columns.Add("icon", typeof(Texture2D));

            foreach (KeyValuePair<string, Texture2D> iconEntry in this.icons)
            {
                DataRow hashTypeRow = tmp_dt.NewRow();
                hashTypeRow["name"] = iconEntry.Key;
                hashTypeRow["icon"] = iconEntry.Value;
                tmp_dt.Rows.Add(hashTypeRow);
            }


            //Reset items from combobox
            comboBox_airplaneAvailableIcons.Items.Clear();

            comboBox_airplaneAvailableIcons.ValueMember = "icon";
            comboBox_airplaneAvailableIcons.DisplayMember = "name";
            comboBox_airplaneAvailableIcons.DataSource = tmp_dt;
        }

        private void comboBox_airplanePresets_SelectedValueChanged(object sender, EventArgs e)
        {
            //Load preset into form
            DataRowView selectedValueRow = (DataRowView)comboBox_airplanePresets.SelectedItem;
            if(selectedValueRow == null) { return; }
            iAirplanePreset airplanePreset = (iAirplanePreset)selectedValueRow[1];
            textBox_airplaneVendor.Text = airplanePreset.getVendor();
            textBox_airplaneModel.Text = airplanePreset.getModel();
            numericUpDown_airplaneCapacity.Value = (decimal)airplanePreset.getCapacity();
            numericUpDown_airplaneMaxSpeed.Value = (decimal)airplanePreset.getMaxSpeed();
            comboBox_airplaneAvailableIcons.SelectedIndex = comboBox_airplaneAvailableIcons.FindStringExact(airplanePreset.getIconName());
        }

        private void button_randomAirplaneId_Click(object sender, EventArgs e)
        {
            textBox_airplaneId.Text = game.generateRandomId();
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

            numericUpDown_airplaneCapacity.Minimum = Game1.minMaxCapacity[0];
            numericUpDown_airplaneCapacity.Maximum = Game1.minMaxCapacity[1];

            numericUpDown_airplaneAltitude.Minimum = Game1.minMaxAltitude[0];
            numericUpDown_airplaneAltitude.Maximum = Game1.minMaxAltitude[1];


            numericUpDown_airplaneMaxSpeed.Minimum = Game1.minMaxMAXSpeed[0];
            numericUpDown_airplaneMaxSpeed.Maximum = Game1.minMaxMAXSpeed[1];

            numericUpDown_airplaneVerticalAcceleration.Minimum = Game1.minMaxVerticalAcceleration[0];
            numericUpDown_airplaneVerticalAcceleration.Maximum = Game1.minMaxVerticalAcceleration[1];

            numericUpDown_airplaneSpeed.Minimum = Game1.minMaxMAXSpeed[0];
            numericUpDown_airplaneSpeed.Maximum = Game1.minMaxMAXSpeed[1];
        }

        private void comboBox_airplaneAvailableIcons_SelectedValueChanged(object sender, EventArgs e)
        {
            //Load preset into form
            DataRowView selectedValueRow = (DataRowView)comboBox_airplaneAvailableIcons.SelectedItem;
            if (selectedValueRow == null) { return; }
            this.selectedAirplaneIcon = (Texture2D)selectedValueRow[1];

        }
    }
}
