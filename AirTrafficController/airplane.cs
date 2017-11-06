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
        private Vector2 direction;
        private map map;
        private Game1 game;
        private bool drawInfo = true;
        private bool hovering = false;
        //Dangers
        private bool collisionDanger = false;
        private List<iAirplane> collisionDangerWith;
        public airplane(map map)
        {
            this.map = map;
            collisionDangerWith = new List<iAirplane>();
        }
        public void Initialize(string id, string vendor, string model, Vector2 pos, Vector2 direction, int altitude, int speed, int maxSpeed, int acceleration, int capacity)
        {
            this.id = id;
            this.vendor = vendor;
            this.model = model;
            this.pos = pos;
            this.direction = direction;
            this.altitude = altitude;
            this.speed = speed;
            this.acceleration = acceleration;
            this.maxSpeed = maxSpeed;
            this.capacity = capacity;
            this.game = this.map.getGame();
            this.icon = this.game.icons["AirbusA380"];
        }
        public void Update()
        {
            //Calculate new pos with speed and acceleration
            if (this.speed < this.maxSpeed)
            {
                this.speed = this.speed + this.acceleration;
            }
            else if(this.speed > this.maxSpeed)
            {
                this.speed = this.maxSpeed;
            }
            else
            {
                //This will make speed unestable (not linear)
                this.speed = this.speed - this.speed * this.acceleration / 100;
            }
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
            if (this.drawInfo)
            {
                Vector2 stringOffset = this.map.getGame().defaultFont.MeasureString(this.vendor + " " + this.model + " - " + this.id);
                spriteBatch.DrawString(this.map.getGame().defaultFont, this.vendor + " " + this.model + " - " + this.id, drawPos + new Vector2(-(stringOffset.X) / 2, -70), Color.Black);

                spriteBatch.DrawString(this.map.getGame().defaultFont, drawPos.ToString(), drawPos + new Vector2(30, -40), Color.Black);
                spriteBatch.DrawString(this.map.getGame().defaultFont, "Alt: " + this.altitude + "m", drawPos + new Vector2(30, -20), Color.Black);
                spriteBatch.DrawString(this.map.getGame().defaultFont, this.speed.ToString() + " u/s", drawPos + new Vector2(30, 0), Color.Black);
            }
            if (this.collisionDangerWith.Count > 0)
            {
                spriteBatch.DrawString(this.map.getGame().defaultFont, "COLLISION DANGER!!!", drawPos + new Vector2(0, 20), Color.Red);
                foreach(iAirplane collisionDangerAirplane in collisionDangerWith)
                {
                    Primitives2D.DrawLine(spriteBatch, this.drawPos, collisionDangerAirplane.getDrawPos(), Color.Red);
                }
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
    }
}
