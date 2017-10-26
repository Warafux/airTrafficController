using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTrafficController
{
    public class map
    {
        private Game1 game;
        private Vector2 size;
        public Vector2 pos;
        private int distanceCollisionDanger = 2000;
        private int distanceCrash = 500;

        private List<iAirplane> airplanes = new List<iAirplane>();

        //DRAW PROPERTIES

        public map(Game1 game, Vector2 pos, Vector2 size)
        {
            this.game = game;
            this.pos = pos;
            this.size = size;
        }
        public void addAirplane(iAirplane airplane)
        {
            if (!existIdInMap(airplane.getId()))
            {
                airplanes.Add(airplane);
            }
        }
        public void Update(GameTime gameTime)
        {
            //First update ALL AIRPLANES
            foreach (iAirplane airplane in airplanes)
            {
                airplane.Update();
            }

            //Then check for problems
            foreach (iAirplane airplane1 in airplanes)
            {
                //Check if airplane stills on map after update
                if (!isValidAirplanePos(airplane1))
                {
                    Console.WriteLine("INVALID POS, REMOVING");
                    airplanes.Remove(airplane1);
                    break;
                }
                //Check if it would crash
                bool wouldCrash = false;
                foreach (iAirplane airplane2 in this.airplanes)
                {
                    //Same airplane, stop
                    if (airplane1.getId() == airplane2.getId()) { break; }

                    //Calculate distance between 2 airplanes
                    double distance = Vector2.Distance(airplane1.getPos(), airplane2.getPos());
                    if (distance < this.distanceCrash)
                    {
                        this.game.addNotification($"Airplane {airplane1.getId()} and airplane {airplane2.getId()} have crashed. {airplane1.getCapacity() + airplane2.getCapacity()} people have died. Congratulations.", 6000);

                        //Delete the airplane2
                        this.airplanes.Remove(airplane1);
                        this.airplanes.Remove(airplane2);
                        wouldCrash = true;
                        break;
                    }
                }
                if (wouldCrash) { break; }

                //check collisions
                checkCollisionDanger(airplane1);
            }
        }
        private bool isValidAirplanePos(iAirplane airplane)
        {
            Vector2 airplanePos = airplane.getPos();
            return (airplanePos.X < this.size.X && airplanePos.X >= 0) && (airplanePos.Y < this.size.Y && airplanePos.Y >= 0);
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            //We calculate the area of the window
            Vector2 drawSize = new Vector2(game.GraphicsDevice.Viewport.Width - 2, game.GraphicsDevice.Viewport.Height - 2);
            utilDraw.drawRectangle(spriteBatch, game.lineTexture, new Rectangle(pos.ToPoint(), drawSize.ToPoint()), Color.Black);
            foreach(iAirplane airplane in airplanes)
            {
                airplane.Draw(spriteBatch);
            }
        }
        public Vector2 getSize()
        {
            return this.size;
        }
        public Game1 getGame()
        {
            return this.game;
        }
        public List<iAirplane> getAirplanes()
        {
            return airplanes;
        }
        public bool existIdInMap(string id)
        {
            foreach (iAirplane airplane in airplanes)
            {
                if(airplane.getId() == id)
                {
                    return true;
                }
            }
            return false;
        }
        public void checkCollisionDanger(iAirplane airplane1)
        {
            airplane1.removeAllCollisionDangerWith();
            foreach (iAirplane airplane2 in airplanes)
            {
                //Same airplane, stop
                if (airplane1.getId() == airplane2.getId()) { break; }

                //Calculate distance between 2 airplanes
                double distance = Vector2.Distance(airplane1.getPos(), airplane2.getPos());
                if (distance < this.distanceCollisionDanger)
                {
                    //this.game.addNotification($"Airplane {airplane1.getId()} and airplane {airplane2.getId()} are really close!!({(int)Math.Round(distance)})", 6000);
                    airplane1.addCollisionDangerWith(airplane2);
                    airplane2.addCollisionDangerWith(airplane1);

                    
                }
            }
        }
        public void checkCrash(iAirplane airplane1)
        {
            foreach (iAirplane airplane2 in this.airplanes)
            {
                //Same airplane, stop
                if (airplane1.getId() == airplane2.getId()) { break; }

                //Calculate distance between 2 airplanes
                double distance = Vector2.Distance(airplane1.getPos(), airplane2.getPos());
                if (distance < this.distanceCrash)
                {
                    this.game.addNotification($"Airplane {airplane1.getId()} and airplane {airplane2.getId()} have crashed. {airplane1.getCapacity() + airplane2.getCapacity()} people have died. Congratulations.", 6000);

                    //Delete the airplane2
                    this.airplanes.Remove(airplane1);
                    this.airplanes.Remove(airplane2);
                    break;
                }
            }
            return;
        }
        public void clearMap()
        {
            this.airplanes = new List<iAirplane>();
        }
        public int getDistanceCollisionDanger()
        {
            return this.distanceCollisionDanger;
        }
    }
}
