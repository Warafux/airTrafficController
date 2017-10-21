using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirTrafficController
{
    public partial class menuForm : Form
    {
        Game1 game;
        public menuForm()
        {
            InitializeComponent();
        }

        private void menuForm_Load(object sender, EventArgs e)
        {

        }
        public void setGame(Game1 game)
        {
            this.game = game;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            game.addNotification(textBox_messageNotification.Text);
        }
    }
}
