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
        }

        private void menuForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.newAirplaneForm.Dispose();
            this.newAirplaneForm = new newAirplaneForm(game);
            this.newAirplaneForm.Show();
        }
        public void updateAll()
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            testForm = new testForm(this.game);
            testForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            game.switchGameRunning();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.editAirplaneForm.Dispose();
            this.editAirplaneForm = new editAirplaneForm(game);
            this.editAirplaneForm.Show();
        }

        private void menuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.game.Exit();
        }
    }
}
