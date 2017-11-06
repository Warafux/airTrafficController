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
        private int distanceCollisionDangerRadius = 2000;
        private int distanceCrashRadius = 800;

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

            bool allOk = false;
            while (!allOk)
            {
                allOk = true;
                List<iAirplane> totalAirplanesToBeRemoved = new List<iAirplane>();

                foreach (iAirplane airplane in airplanes)
                {
                    if (checkCrash(airplane))
                    {
                        allOk = false;
                        totalAirplanesToBeRemoved.Add(airplane);
                    }
                }
                removeAirplanes(totalAirplanesToBeRemoved);
            }

            //Finally, check collisions DANGER
            foreach (iAirplane airplane in airplanes)
            {
                checkCollisionDanger(airplane);
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
                if (airplane1.getId() == airplane2.getId()) { continue; }

                //Calculate distance between 2 airplanes
                double radius = Vector3.Distance(airplane1.get3DPos(), airplane2.get3DPos());
                if (radius < this.distanceCollisionDangerRadius)
                {
                    //this.game.addNotification($"Airplane {airplane1.getId()} and airplane {airplane2.getId()} are really close!!({(int)Math.Round(distance)})", 6000);
                    airplane1.addCollisionDangerWith(airplane2);
                    airplane2.addCollisionDangerWith(airplane1);
                }
            }
        }
        private void removeAirplanes(List<iAirplane> List)
        {
            foreach(iAirplane airplane in List)
            {
                this.airplanes.Remove(airplane);
            }
        }
        public bool checkCrash(iAirplane airplane1)
        {
            foreach (iAirplane airplane2 in this.airplanes)
            {
                //Same airplane, stop
                if (airplane1.getId() == airplane2.getId()) { continue; }

                //Calculate distance between 2 airplanes
                double radius = Vector3.Distance(airplane1.get3DPos(), airplane2.get3DPos());
                if (radius < this.distanceCrashRadius)
                {
                    this.game.addNotification($"Airplane {airplane1.getId()} has crashed. {airplane1.getCapacity()} people have died. Congratulations.", 6000);

                    return true;
                }
            }
            return false;
        }
        public void clearMap()
        {
            this.airplanes = new List<iAirplane>();
        }
        public int getDistanceCollisionDanger()
        {
            return this.distanceCollisionDangerRadius;
        }
    }
}
