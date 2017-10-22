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
        public menuForm()
        {
            InitializeComponent();
            newAirplaneForm = new newAirplaneForm();
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
            newAirplaneForm.Dispose();
            newAirplaneForm = new newAirplaneForm(game);
            newAirplaneForm.Show();
        }
        public void updateAll()
        {

        }
    }
}
