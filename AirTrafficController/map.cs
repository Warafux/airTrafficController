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
        private int distanceCollisionDangerRadius = 1800;
        private int distanceCrashRadius = 800;
        private int altitudeDanger = Game1.minMaxAltitude[0] + 150;
        private int altitudeCrash = Game1.minMaxAltitude[0];
        private int landingMaxSpeed = 50;
        private stats stats;
        private List<iAirplane> airplanes = new List<iAirplane>();

        //DRAW PROPERTIES

        public map(Game1 game, Vector2 pos, Vector2 size)
        {
            this.game = game;
            this.pos = pos;
            this.size = size;
        }
        public void setStats(stats stats)
        {
            this.stats = stats;
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

            //Check if pos are valid
            List<iAirplane> totalAirplanesToBeRemoved = new List<iAirplane>();
            foreach (iAirplane airplane in airplanes)
            {
                if (!isValidAirplanePos(airplane))
                {
                    totalAirplanesToBeRemoved.Add(airplane);
                }
            }
            removeAirplanes(totalAirplanesToBeRemoved);

            //Check collisions crashes
            bool allOk = false;
            while (!allOk)
            {
                allOk = true;
                totalAirplanesToBeRemoved.Clear(); // Reset list

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

            //Then, check collisions/altitude DANGER
            foreach (iAirplane airplane in airplanes)
            {
                checkCollisionDanger(airplane);
                checkAltitudeDanger(airplane);
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
        public void checkAltitudeDanger(iAirplane airplane)
        {
            airplane.setAltitudeDanger(false);
            if (airplane.getAltitude() <= this.altitudeDanger)
            {
                airplane.setAltitudeDanger(true);
            } 
        }
        public void checkCollisionDanger(iAirplane airplane1)
        {
            //Reset collision danger list
            airplane1.removeAllCollisionDangerWith();
            foreach (iAirplane airplane2 in airplanes)
            {
                //Same airplane, stop
                if (airplane1.getId() == airplane2.getId()) { continue; }

                //Calculate distance between 2 airplanes
                double radius = Vector3.Distance(airplane1.get3DPos(), airplane2.get3DPos());
                if (radius <= this.distanceCollisionDangerRadius)
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
            //CRASH with floor/ground(altitude)
            if(airplane1.getAltitude() <= this.altitudeCrash)
            {
                if (airplane1.getDeployedLandingGear())
                {
                    //Landing gear is deployed
                    if(airplane1.getSpeed() <= this.landingMaxSpeed)
                    {
                        //Airplane can land and be removed
                        this.game.addNotification($"Airplane {airplane1.getId()} has landed succesfully.", 6000);
                    }
                    else
                    {
                        Random random = new Random();
                        int deadPeople = random.Next((int)(airplane1.getCapacity() * 0.2), (int)(airplane1.getCapacity() * 0.8));
                        this.game.addNotification($"Airplane {airplane1.getId()} has landed with some difficulties killing {deadPeople} people.", 6000);
                        this.stats.addDeadPeople($"{airplane1.getId()} - {airplane1.getVendor()} {airplane1.getModel()} Landed with some difficulties killing {deadPeople} people.", deadPeople);
                    }
                }
                else
                {
                    //Landing gear is not deployed
                    this.game.addNotification($"Airplane {airplane1.getId()} has crashed with the ground. {airplane1.getCapacity()} people have died. Congratulations.", 6000);
                    this.stats.addDeadPeople($"{airplane1.getId()} - {airplane1.getVendor()} {airplane1.getModel()} has crashed with the ground. {airplane1.getCapacity()} people have died.", airplane1.getCapacity());
                }

                return true;
            }

            //CRASH with airplanes
            foreach (iAirplane airplane2 in this.airplanes)
            {
                //Same airplane, stop
                if (airplane1.getId() == airplane2.getId()) { continue; }

                //Calculate distance between 2 airplanes
                double radius = Vector3.Distance(airplane1.get3DPos(), airplane2.get3DPos());
                if (radius <= this.distanceCrashRadius)
                {
                    this.game.addNotification($"Airplane {airplane1.getId()} has crashed with another airplane. {airplane1.getCapacity()} people have died. Congratulations.", 6000);
                    this.stats.addDeadPeople($"{airplane1.getId()} - {airplane1.getVendor()} {airplane1.getModel()} has crashed with another airplane. {airplane1.getCapacity()} people have died.", airplane1.getCapacity());
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
