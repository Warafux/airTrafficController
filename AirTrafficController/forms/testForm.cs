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
                this.game.icons.ElementAt(0).Value,
                "xd",
                "xd",
                new Vector2(random.Next(1, (int)gameMap.getSize().X), random.Next(1, (int)gameMap.getSize().Y)),
                chosenDirection,
                random.Next(Game1.minMaxAltitude[0], Game1.minMaxAltitude[1]),
                random.Next(Game1.minMaxMAXSpeed[0], Game1.minMaxMAXSpeed[1]),
                random.Next(Game1.minMaxMAXSpeed[0], Game1.minMaxMAXSpeed[1]),
                random.Next(Game1.minMaxAcceleration[0], Game1.minMaxAcceleration[1]),
                random.Next(Game1.minMaxVerticalAcceleration[0], Game1.minMaxVerticalAcceleration[1]),
                random.Next(Game1.minMaxCapacity[0], Game1.minMaxCapacity[1])
            );

            this.game.addAirplaneToMap(airplane);
        }

        private void button_testCollision_Click(object sender, EventArgs e)
        {
            map gameMap = game.getMap();
            gameMap.clearMap();

            airplane airplane1 = new airplane(gameMap);
            Random random = new Random();
            airplane1.Initialize(
                "T1",
                this.game.icons.ElementAt(0).Value,
                "TEST CRASH",
                "1",
                new Vector2(gameMap.getSize().X / 2, gameMap.getSize().Y * 0.75f),
                utilVector2.getDirectionFromString("Up"),
                Game1.minMaxAltitude[1],
                random.Next(Game1.minMaxMAXSpeed[0], Game1.minMaxMAXSpeed[1]),
                random.Next(Game1.minMaxMAXSpeed[0], Game1.minMaxMAXSpeed[1]),
                random.Next(Game1.minMaxAcceleration[0], Game1.minMaxAcceleration[1]),
                random.Next(Game1.minMaxVerticalAcceleration[0], Game1.minMaxVerticalAcceleration[1]),
                random.Next(Game1.minMaxCapacity[0], Game1.minMaxCapacity[1])
            );

            airplane airplane2 = new airplane(gameMap);
            airplane2.Initialize(
                "T2",
                this.game.icons.ElementAt(0).Value,
                "TEST CRASH",
                "2",
                new Vector2(gameMap.getSize().X / 2, gameMap.getSize().Y * 0.25f),
                utilVector2.getDirectionFromString("Down"),
                Game1.minMaxAltitude[1],
                random.Next(Game1.minMaxMAXSpeed[0], Game1.minMaxMAXSpeed[1]),
                random.Next(Game1.minMaxMAXSpeed[0], Game1.minMaxMAXSpeed[1]),
                random.Next(Game1.minMaxAcceleration[0], Game1.minMaxAcceleration[1]),
                random.Next(Game1.minMaxVerticalAcceleration[0], Game1.minMaxVerticalAcceleration[1]),
                random.Next(Game1.minMaxCapacity[0], Game1.minMaxCapacity[1])
            );

            this.game.addAirplaneToMap(airplane1);
            this.game.addAirplaneToMap(airplane2);
        }

        private void button_testMultipleCollision_Click(object sender, EventArgs e)
        {
            map gameMap = game.getMap();
            gameMap.clearMap();

            airplane airplane1 = new airplane(gameMap);
            Random random = new Random();
            airplane1.Initialize(
                "T1",
                this.game.icons.ElementAt(0).Value,
                "TEST CRASH",
                "1",
                new Vector2(gameMap.getSize().X / 2, gameMap.getSize().Y * 0.75f),
                utilVector2.getDirectionFromString("Up"),
                Game1.minMaxAltitude[1],
                300,
                300,
                Game1.minMaxAcceleration[0],
                Game1.minMaxVerticalAcceleration[0],
                random.Next(Game1.minMaxCapacity[0], Game1.minMaxCapacity[1])
            );

            airplane airplane2 = new airplane(gameMap);
            airplane2.Initialize(
                "T2",
                this.game.icons.ElementAt(0).Value,
                "TEST CRASH",
                "2",
                new Vector2(gameMap.getSize().X / 2, gameMap.getSize().Y * 0.25f),
                utilVector2.getDirectionFromString("Down"),
                Game1.minMaxAltitude[1],
                300,
                300,
                Game1.minMaxAcceleration[0],
                Game1.minMaxVerticalAcceleration[0],
                random.Next(Game1.minMaxCapacity[0], Game1.minMaxCapacity[1])
            );

            airplane airplane3 = new airplane(gameMap);
            airplane3.Initialize(
                "T3",
                this.game.icons.ElementAt(0).Value,
                "TEST CRASH",
                "3",
                new Vector2(gameMap.getSize().X * 0.75f, gameMap.getSize().Y / 2 ),
                utilVector2.getDirectionFromString("Left"),
                Game1.minMaxAltitude[1],
                300,
                300,
                Game1.minMaxAcceleration[0],
                Game1.minMaxVerticalAcceleration[0],
                random.Next(Game1.minMaxCapacity[0], Game1.minMaxCapacity[1])
            );

            airplane airplane4 = new airplane(gameMap);
            airplane4.Initialize(
                "T4",
                this.game.icons.ElementAt(0).Value,
                "TEST CRASH",
                "4",
                new Vector2(gameMap.getSize().X * 0.25f, gameMap.getSize().Y / 2),
                utilVector2.getDirectionFromString("Right"),
                Game1.minMaxAltitude[1],
                300,
                300,
                Game1.minMaxAcceleration[0],
                Game1.minMaxVerticalAcceleration[0],
                random.Next(Game1.minMaxCapacity[0], Game1.minMaxCapacity[1])
            );

            this.game.addAirplaneToMap(airplane1);
            this.game.addAirplaneToMap(airplane2);
            this.game.addAirplaneToMap(airplane3);
            this.game.addAirplaneToMap(airplane4);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            map gameMap = game.getMap();
            gameMap.clearMap();

            airplane airplane1 = new airplane(gameMap);
            Random random = new Random();
            airplane1.Initialize(
                "T1",
                this.game.icons.ElementAt(0).Value,
                "TEST CRASH",
                "1",
                new Vector2(gameMap.getSize().X / 2, gameMap.getSize().Y * 0.75f),
                utilVector2.getDirectionFromString("Up"),
                Game1.minMaxAltitude[1],
                random.Next(Game1.minMaxMAXSpeed[0], Game1.minMaxMAXSpeed[1]),
                random.Next(Game1.minMaxMAXSpeed[0], Game1.minMaxMAXSpeed[1]),
                random.Next(Game1.minMaxAcceleration[0], Game1.minMaxAcceleration[1]),
                random.Next(Game1.minMaxVerticalAcceleration[0], Game1.minMaxVerticalAcceleration[1]),
                random.Next(Game1.minMaxCapacity[0], Game1.minMaxCapacity[1])
            );

            airplane airplane2 = new airplane(gameMap);
            airplane2.Initialize(
                "T2",
                this.game.icons.ElementAt(0).Value,
                "TEST CRASH",
                "2",
                new Vector2(gameMap.getSize().X / 2, gameMap.getSize().Y * 0.25f),
                utilVector2.getDirectionFromString("Down"),
                Game1.minMaxAltitude[1],
                random.Next(Game1.minMaxMAXSpeed[0], Game1.minMaxMAXSpeed[1]),
                random.Next(Game1.minMaxMAXSpeed[0], Game1.minMaxMAXSpeed[1]),
                random.Next(Game1.minMaxAcceleration[0], Game1.minMaxAcceleration[1]),
                random.Next(Game1.minMaxVerticalAcceleration[0], Game1.minMaxVerticalAcceleration[1]),
                random.Next(Game1.minMaxCapacity[0], Game1.minMaxCapacity[1])
            );

            airplane airplane3 = new airplane(gameMap);
            airplane3.Initialize(
                "T3",
                this.game.icons.ElementAt(0).Value,
                "TEST CRASH",
                "3",
                new Vector2(gameMap.getSize().X * 0.75f, gameMap.getSize().Y / 2 ),
                utilVector2.getDirectionFromString("Left"),
                Game1.minMaxAltitude[1],
                random.Next(Game1.minMaxMAXSpeed[0], Game1.minMaxMAXSpeed[1]),
                random.Next(Game1.minMaxMAXSpeed[0], Game1.minMaxMAXSpeed[1]),
                random.Next(Game1.minMaxAcceleration[0], Game1.minMaxAcceleration[1]),
                random.Next(Game1.minMaxVerticalAcceleration[0], Game1.minMaxVerticalAcceleration[1]),
                random.Next(Game1.minMaxCapacity[0], Game1.minMaxCapacity[1])
            );

            airplane airplane4 = new airplane(gameMap);
            airplane4.Initialize(
                "T4",
                this.game.icons.ElementAt(0).Value,
                "TEST CRASH",
                "4",
                new Vector2(gameMap.getSize().X * 0.25f, gameMap.getSize().Y / 2),
                utilVector2.getDirectionFromString("Right"),
                Game1.minMaxAltitude[1],
                random.Next(Game1.minMaxMAXSpeed[0], Game1.minMaxMAXSpeed[1]),
                random.Next(Game1.minMaxMAXSpeed[0], Game1.minMaxMAXSpeed[1]),
                random.Next(Game1.minMaxAcceleration[0], Game1.minMaxAcceleration[1]),
                random.Next(Game1.minMaxVerticalAcceleration[0], Game1.minMaxVerticalAcceleration[1]),
                random.Next(Game1.minMaxCapacity[0], Game1.minMaxCapacity[1])
            );

            this.game.addAirplaneToMap(airplane1);
            this.game.addAirplaneToMap(airplane2);
            this.game.addAirplaneToMap(airplane3);
            this.game.addAirplaneToMap(airplane4);
        }

        private void button_testCollisionGround_Click(object sender, EventArgs e)
        {
            map gameMap = game.getMap();
            gameMap.clearMap();

            airplane airplane1 = new airplane(gameMap);
            Random random = new Random();
            airplane1.Initialize(
                "T1",
                this.game.icons.ElementAt(0).Value,
                "TEST CRASH",
                "1",
                new Vector2(gameMap.getSize().X / 2, gameMap.getSize().Y * 0.75f),
                utilVector2.getDirectionFromString("Up"),
                Game1.minMaxAltitude[0] + 600,
                random.Next(Game1.minMaxMAXSpeed[0], Game1.minMaxMAXSpeed[0] + 400),
                random.Next(Game1.minMaxMAXSpeed[0], Game1.minMaxMAXSpeed[0] + 800) ,
                random.Next(Game1.minMaxAcceleration[0], Game1.minMaxAcceleration[1]),
                random.Next(Game1.minMaxVerticalAcceleration[0], Game1.minMaxVerticalAcceleration[1]),
                random.Next(Game1.minMaxCapacity[0], Game1.minMaxCapacity[1])
            );
            airplane1.setIsOn(false);
            this.game.addAirplaneToMap(airplane1);
        }

        private void button_testNoCollisionAirplaneAltitude_Click(object sender, EventArgs e)
        {
            map gameMap = game.getMap();
            gameMap.clearMap();

            airplane airplane1 = new airplane(gameMap);
            Random random = new Random();
            airplane1.Initialize(
                "T1",
                this.game.icons.ElementAt(0).Value,
                "TEST CRASH",
                "1",
                new Vector2(gameMap.getSize().X / 2, gameMap.getSize().Y * 0.75f),
                utilVector2.getDirectionFromString("Up"),
                Game1.minMaxAltitude[0] + 200,
                random.Next(Game1.minMaxMAXSpeed[0], Game1.minMaxMAXSpeed[1]),
                random.Next(Game1.minMaxMAXSpeed[0], Game1.minMaxMAXSpeed[1]),
                random.Next(Game1.minMaxAcceleration[0], Game1.minMaxAcceleration[1]),
                random.Next(Game1.minMaxVerticalAcceleration[0], Game1.minMaxVerticalAcceleration[1]),
                random.Next(Game1.minMaxCapacity[0], Game1.minMaxCapacity[1])
            );

            airplane airplane2 = new airplane(gameMap);
            airplane2.Initialize(
                "T2",
                this.game.icons.ElementAt(0).Value,
                "TEST CRASH",
                "2",
                new Vector2(gameMap.getSize().X / 2, gameMap.getSize().Y * 0.25f),
                utilVector2.getDirectionFromString("Down"),
                Game1.minMaxAltitude[1],
                random.Next(Game1.minMaxMAXSpeed[0], Game1.minMaxMAXSpeed[1]),
                random.Next(Game1.minMaxMAXSpeed[0], Game1.minMaxMAXSpeed[1]),
                random.Next(Game1.minMaxAcceleration[0], Game1.minMaxAcceleration[1]),
                random.Next(Game1.minMaxVerticalAcceleration[0], Game1.minMaxVerticalAcceleration[1]),
                random.Next(Game1.minMaxCapacity[0], Game1.minMaxCapacity[1])
            );

            this.game.addAirplaneToMap(airplane1);
            this.game.addAirplaneToMap(airplane2);
        }
    }
}
