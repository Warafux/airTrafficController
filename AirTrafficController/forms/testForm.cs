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
    public partial class testForm : Form
    {
        private Game1 game;
        public testForm(Game1 game)
        {
            InitializeComponent();
            this.game = game;
        }

        private void testForm_Load(object sender, EventArgs e)
        {

        }

        private void button_addRandomAirplane_Click(object sender, EventArgs e)
        {
            map gameMap = game.getMap();
            airplane airplane = new airplane(gameMap);
            Random random = new Random();
            Vector2 chosenDirection = utilVector2.getRandomDirection();
            airplane.Initialize(
                this.game.generateRandomId(),
                "xd",
                "xd",
                new Vector2(random.Next(1, (int)gameMap.getSize().X), random.Next(1, (int)gameMap.getSize().Y)),
                chosenDirection,
                10,
                random.Next(200, 300),
                random.Next(1, 500),
                random.Next(1, 5),
                random.Next(20, 400)
            );

            gameMap.addAirplane(airplane);
        }

        private void button_testCollision_Click(object sender, EventArgs e)
        {
            map gameMap = game.getMap();
            gameMap.clearMap();

            airplane airplane1 = new airplane(gameMap);
            Random random = new Random();
            airplane1.Initialize(
                "T1",
                "TEST CRASH",
                "1",
                new Vector2(gameMap.getSize().X / 2, gameMap.getSize().Y * 0.75f),
                utilVector2.getDirectionFromString("Up"),
                10,
                random.Next(200, 300),
                random.Next(1, 500),
                random.Next(1, 5),
                random.Next(20, 400)
            );

            airplane airplane2 = new airplane(gameMap);
            airplane2.Initialize(
                "T2",
                "TEST CRASH",
                "2",
                new Vector2(gameMap.getSize().X / 2, gameMap.getSize().Y * 0.25f),
                utilVector2.getDirectionFromString("Down"),
                10,
                random.Next(200, 300),
                random.Next(1, 500),
                random.Next(1, 5),
                random.Next(20, 400)
            );

            gameMap.addAirplane(airplane1);
            gameMap.addAirplane(airplane2);
        }
    }
}
