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
    public partial class statsForm : Form
    {
        private Game1 game;
        private stats stats;
        public statsForm()
        {
        }
        public statsForm(Game1 game)
        {
            InitializeComponent();
            this.game = game;
            this.stats = this.game.getStats();
            this.loadValues();
        }
        public void setGame(Game1 game)
        {
            this.game = game;
        }
        private void loadValues()
        {
            this.label_deadPeopleCounter.Text = $"{this.stats.getDeadPeople()}";
            this.loadStringListIntoListBox(this.stats.getDeadPeopleLog(), this.listBox_deadPeopleLog);
        }
        private void loadStringListIntoListBox(List<string> stringList, ListBox listBox)
        {
            listBox.Items.Clear();
            foreach(string str in stringList)
            {
                listBox.Items.Add(str);
            }
        }
    }
}
