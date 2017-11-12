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
    public partial class menuForm : Form
    {
        Game1 game;
        //Secondary forms:
        newAirplaneForm newAirplaneForm;
        testForm testForm;
        editAirplaneForm editAirplaneForm;
        public menuForm()
        {
            InitializeComponent();
            this.newAirplaneForm = new newAirplaneForm();
            this.editAirplaneForm = new editAirplaneForm();
        }
        public void setGame(Game1 game)
        {
            this.game = game;
            this.label_runningStatus.Text = this.game.getGameRunning() ? "ON" : "OFF";
        }

        private void menuForm_Load(object sender, EventArgs e)
        {
            
        }
        public void updateAll()
        {

        }

        private void menuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.game.Exit();
        }

        private void button_switchGameRunning_Click(object sender, EventArgs e)
        {
            this.game.switchGameRunning();
            this.label_runningStatus.Text = this.game.getGameRunning() ? "ON" : "OFF";
            if (this.game.getGameRunning())
            {
                //if game is running, restart edit form
                this.editAirplaneForm.Dispose();
                this.editAirplaneForm = new editAirplaneForm(game);
            }
        }

        private void button_editAirplanes_Click(object sender, EventArgs e)
        {
            this.label_runningStatus.Text = this.game.getGameRunning() ? "ON" : "OFF";
            if (!this.game.getGameRunning())
            {
                this.editAirplaneForm.Dispose();
                this.editAirplaneForm = new editAirplaneForm(game);
                this.editAirplaneForm.Show();
            }
            else
            {
                MessageBox.Show("Impossible to edit airplanes while simulation is running.");
            }
        }

        private void button_tests_Click(object sender, EventArgs e)
        {
            this.testForm = new testForm(this.game);
            this.testForm.Show();
        }

        private void button_newAirplane_Click(object sender, EventArgs e)
        {
            this.newAirplaneForm.Dispose();
            this.newAirplaneForm = new newAirplaneForm(game);
            this.newAirplaneForm.Show();
        }


    }
}
