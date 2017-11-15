using AirTrafficController.util;
using C3.XNA;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTrafficController
{
    public class airplane : iAirplane
    {
        public Texture2D icon;
        private string vendor = "";
        private string model = "";
        private string id = "";
        private Vector2 pos;
        private Vector2 drawPos;
        private int altitude = 0;
        private int speed;
        private int maxSpeed;
        private int capacity;
        private int acceleration;
        private int verticalAcceleration;
        private Vector2 direction;
        private bool deployedLandingGear = false;

        private bool isOn = true;//Motor status

        private map map;
        private Game1 game;

        //GUI vars
        private bool drawInfo = true;
        private bool hovering = false;

        

        //Dangers
        private bool collisionDanger = false;
        private List<iAirplane> collisionDangerWith;

        private bool fallingDanger = false;

        private bool altitudeDanger = false;

        public airplane(map map)
        {
            this.map = map;
            collisionDangerWith = new List<iAirplane>();
        }
        public void Initialize(string id, Texture2D icon, string vendor, string model, Vector2 pos, Vector2 direction, int altitude, int speed, int maxSpeed, int acceleration, int verticalAcceleration, int capacity)
        {
            this.id = id;
            this.vendor = vendor;
            this.model = model;
            this.pos = pos;
            this.direction = direction;
            this.altitude = altitude;
            this.speed = speed;
            this.acceleration = acceleration;
            this.verticalAcceleration = verticalAcceleration;
            this.maxSpeed = maxSpeed;
            this.capacity = capacity;
            this.game = this.map.getGame();
            this.icon = icon;
        }
        public void Update()
        {
            //Calculate new pos with speed and acceleration
            if (this.isOn)
            {
                //Motor is ON
                //horizontal movement
                if(this.acceleration >= 0)
                {
                    //Positive acceleration (ACCELERATING)
                    if (this.speed < (this.maxSpeed - 50))
                    {
                        this.speed = this.speed + this.acceleration;
                    }
                    else if (this.speed > this.maxSpeed)
                    {
                        this.speed = this.maxSpeed;
                    }
                    else
                    {
                        //This will make speed unestable (not linear)
                        this.speed = this.speed - this.speed * this.acceleration / 100;
                    }
                }
                else
                {
                    //Negative acceleration (BRAKING)
                    if(this.speed < Game1.minMaxMAXSpeed[0] + 30)
                    {
                        this.speed = Game1.minMaxMAXSpeed[0] + Math.Abs(this.acceleration) + 20;
                        this.acceleration = 2;//STOP BRAKING
                        this.game.addNotification($"Airplane {this.id} has reached the minimum speed! Accelerating again...");
                    }
                    else
                    {
                        this.speed = this.speed + this.acceleration;
                    }
                }


                //vertical movement
                this.fallingDanger = false;
                if(this.altitude < Game1.minMaxAltitude[1])
                {
                    this.altitude = this.altitude + this.verticalAcceleration;
                }
            }
            else
            {
                //Motor is OFF, speed-- and altitude--
                this.speed = MathHelper.Clamp(this.speed - this.acceleration * 4 - 15, Game1.minMaxMAXSpeed[0], Game1.minMaxMAXSpeed[1]);
                this.altitude = MathHelper.Clamp(this.altitude - (int)(9.8 * 2), Game1.minMaxAltitude[0], Game1.minMaxAltitude[1]);
                this.fallingDanger = true;
            }
            //Calculate the pos with new speed
            Vector2 newPos = new Vector2(
                this.direction.X * this.speed + this.pos.X,
                this.direction.Y * this.speed + this.pos.Y
                );
            this.pos = newPos;

            
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            //Calculate pos to draw inside the map
            this.drawPos = new Vector2(
                utilDraw.convertRange(0, (int)this.map.getSize().X, 0, this.map.getGame().GraphicsDevice.Viewport.Width, (int)(this.pos.X)),
                utilDraw.convertRange(0, (int)this.map.getSize().Y, 0, this.map.getGame().GraphicsDevice.Viewport.Height, (int)(this.pos.Y))
                );
            if(this.hovering)
            Primitives2D.DrawCircle(spriteBatch, this.drawPos, 50, 100, Color.Red);

            spriteBatch.Draw(
                this.icon,
                drawPos,
                null,
                Color.Red,
                -(MathHelper.ToRadians(utilVector2.angleOfDirection(this.direction)) % (MathHelper.Pi * 2)), //CALCULATE ROTATION
                new Vector2(this.icon.Width / 2, this.icon.Height / 2), // CALCULATE ORIGIN OF THE SPRITE
                this.game.iconScale,
                SpriteEffects.None,
                0f);
            //spriteBatch.DrawString(this.map.getGame().defaultFont, "XD", this.drawPos, Color.Black);

            int rows = 0;
            if (this.drawInfo)
            {
                Vector2 stringOffset = this.map.getGame().defaultFont.MeasureString(this.vendor + " " + this.model + " - " + this.id);
                spriteBatch.DrawString(this.map.getGame().defaultFont, this.vendor + " " + this.model + " - " + this.id, drawPos + new Vector2(-(stringOffset.X) / 2, 0- ++rows * 20), Color.Black);
                spriteBatch.DrawString(this.map.getGame().defaultFont, this.pos.ToString(), drawPos + new Vector2(30, 0 - ++rows * 20), Color.Black);
                spriteBatch.DrawString(this.map.getGame().defaultFont, "Alt: " + this.altitude + "m", drawPos + new Vector2(30, 0 - ++rows * 20), Color.Black);
                spriteBatch.DrawString(this.map.getGame().defaultFont, this.speed.ToString() + " u/s", drawPos + new Vector2(30, 0 - ++rows * 20), Color.Black);
                spriteBatch.DrawString(this.map.getGame().defaultFont, "MOTOR IS " + (this.isOn ? "ON" : "OFF"), drawPos + new Vector2(30, 0 - ++rows * 20), this.isOn ? Color.Green : Color.Red);
            }


            rows = 0;
            if (this.collisionDangerWith.Count > 0)
            {
                spriteBatch.DrawString(this.map.getGame().defaultFont, "COLLISION DANGER!!!", drawPos + new Vector2(0, 0 + ++rows * 20), Color.Red);
                foreach(iAirplane collisionDangerAirplane in collisionDangerWith)
                {
                    Primitives2D.DrawLine(spriteBatch, this.drawPos, collisionDangerAirplane.getDrawPos(), Color.Red);
                }
            }
            if (this.fallingDanger)
            {
                spriteBatch.DrawString(this.map.getGame().defaultFont, "FALLING DANGER!!!", drawPos + new Vector2(0, 0 + ++rows * 20), Color.Red);
            }
            if (this.altitudeDanger)
            {
                spriteBatch.DrawString(this.map.getGame().defaultFont, "ALTITUDE DANGER!!!", drawPos + new Vector2(0, 0 + ++rows * 20), Color.Red);
            }
            if (this.deployedLandingGear)
            {
                spriteBatch.DrawString(this.map.getGame().defaultFont, "Landing gear is deployed!", drawPos + new Vector2(0, 0 + ++rows * 20), Color.GreenYellow);
            }
            //Reset hovering status
            this.hovering = false;
        }
        public Vector2 getPos()
        {
            return this.pos;
        }
        public void setPos(Vector2 pos)
        {
            this.pos = pos;
        }
        public string getId()
        {
            return this.id; 
        }
        public void switchDrawInfo()
        {
            this.drawInfo = !this.drawInfo;
        }
        public void setDrawInfo(bool drawInfo)
        {
            this.drawInfo = drawInfo;
        }
        public void click()
        {
            this.switchDrawInfo();
        }
        public void hover(bool isHovering)
        {
            this.hovering = isHovering;
        }
        public Vector2 getDrawPos()
        {
            return this.drawPos;
        }
        public void setCollisionDanger(bool collisionDanger)
        {
            this.collisionDanger = collisionDanger;
        }
        public void setAltitudeDanger(bool altitudeDanger)
        {
            this.altitudeDanger = altitudeDanger;
        }
        public string getVendor()
        {
            return this.vendor;
        }
        public string getModel()
        {
            return this.model;
        }
        public int getCapacity()
        {
            return this.capacity;
        }
        public int getMaxSpeed()
        {
            return this.maxSpeed;
        }
        public bool getCollisionDanger()
        {
            return this.collisionDanger;
        }
        public void addCollisionDangerWith(iAirplane airplane)
        {
             this.collisionDangerWith.Add(airplane);
        }
        public void removeCollisionDangerWith(iAirplane airplane)
        {
            this.collisionDangerWith.Remove(airplane);
        }
        public void removeAllCollisionDangerWith()
        {
            this.collisionDangerWith.Clear();
        }
        public Vector3 get3DPos()
        {
            return new Vector3(this.pos.X, this.pos.Y, this.altitude);
        }
        public int getAcceleration()
        {
            return this.acceleration;
        }
        public int getAltitude()
        {
            return this.altitude;
        }
        public Vector2 getDirection()
        {
            return this.direction;
        }
        public bool getIsOn()
        {
            return this.isOn;
        }
        public void setIsOn(bool status)
        {
            this.isOn = status;
        }
        public void switchIsOn()
        {
            this.isOn = !this.isOn;
        }
        public int getSpeed()
        {
            return this.speed;
        }
        public bool getDeployedLandingGear()
        {
            return this.deployedLandingGear;
        }
        public void setDeployedLandingGear(bool deployedLandingGear)
        {
            this.deployedLandingGear = deployedLandingGear;
        }
        public void switchDeployedLandingGear()
        {
            this.deployedLandingGear = !this.deployedLandingGear;
        }
        public int getVerticalAcceleration()
        {
            return this.verticalAcceleration;
        }
        public void setVerticalAcceleration(int verticalAcceleration)
        {
            this.verticalAcceleration = MathHelper.Clamp(verticalAcceleration, Game1.minMaxVerticalAcceleration[0], Game1.minMaxVerticalAcceleration[1]);
        }
        public void setAcceleration(int acceleration)
        {
            this.acceleration = MathHelper.Clamp(acceleration, Game1.minMaxAcceleration[0], Game1.minMaxAcceleration[1]);
        }
        public bool getAltitudeDanger()
        {
            return this.altitudeDanger;
        }
    }
}
