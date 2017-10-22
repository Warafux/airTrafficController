using AirTrafficController.airplanePresets;
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
    public partial class newAirplaneForm : Form
    {
        Game1 game;
        static List<iAirplanePreset> airplanePresets = new List<iAirplanePreset>(
            new iAirplanePreset[] {
                new AirbusA380()
            });

        public newAirplaneForm()
        {
        }
        public newAirplaneForm(Game1 game)
        {
            InitializeComponent();
            this.game = game;
            numericUpDown_airplaneCoordinateX.Maximum = (Decimal)game.getMapSize().X;
            numericUpDown_airplaneCoordinateY.Maximum = (Decimal)game.getMapSize().Y;

            loadAirplanePresets();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_addAirplane_Click(object sender, EventArgs e)
        {
            if (!checkFields()) { return; }
            map gameMap = game.getMap();
            airplane airplane = new airplane(gameMap);

            airplane.Initialize(
                textBox_airplaneId.Text,
                textBox_airplaneVendor.Text,
                textBox_airplaneModel.Text,
                new Vector2((float)numericUpDown_airplaneCoordinateX.Value, (float)numericUpDown_airplaneCoordinateY.Value),
                Vector2.Zero,
                (int)numericUpDown_altitude.Value,
                (int)numericUpDown_airplaneSpeed.Value,
                (int)numericUpDown_airplaneAcceleration.Value
            );

            gameMap.addAirplane(airplane);
            this.Close();
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

        }

        private void loadAirplanePresets()
        {
            DataTable tmp_dt = new DataTable();
            tmp_dt.Clear();
            tmp_dt.Columns.Add("name", typeof(String));
            tmp_dt.Columns.Add("airplanePreset", typeof(iAirplanePreset));

            foreach (iAirplanePreset airplanePreset in newAirplaneForm.airplanePresets)
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

        private void comboBox_airplanePresets_SelectedValueChanged(object sender, EventArgs e)
        {
            //Load preset into form
            DataRowView selectedValueRow = (DataRowView)comboBox_airplanePresets.SelectedItem;
            if(selectedValueRow == null) { return; }
            iAirplanePreset airplanePreset = (iAirplanePreset)selectedValueRow[1];
            textBox_airplaneVendor.Text = airplanePreset.getVendor();
            textBox_airplaneModel.Text = airplanePreset.getModel();
            numericUpDown_airplaneCapacity.Value = (decimal)airplanePreset.getCapacity();
        }
    }
}
