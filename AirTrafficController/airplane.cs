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
        private int acceleration;
        private Vector2 direction;
        private map map;
        private Game1 game;
        private bool drawInfo = true;
        private bool hovering = false;

        public airplane(map map)
        {
            /*Random random = new Random();
            this.pos = new Vector2(random.Next(1, 999), random.Next(1, 999));
            this.speed = random.Next(1, 20);
            this.acceleration = random.Next(1, 5);*/
            this.map = map;

            Vector2 drawPos = new Vector2(
                utilDraw.convertRange(0, (int)map.getSize().X, 0, map.getGame().GraphicsDevice.Viewport.Width, (int)this.pos.X),
                utilDraw.convertRange(0, (int)map.getSize().Y, 0, map.getGame().GraphicsDevice.Viewport.Height, (int)this.pos.Y)
                );
           // Console.WriteLine(drawPos.ToString());
            //Console.WriteLine("MAP SIZE: " + map.getSize().ToString());
            //Console.WriteLine("WINDOW SIZE: " + map.getGame().GraphicsDevice.Viewport.Width + " , " + map.getGame().GraphicsDevice.Viewport.Height);
        }
        public void Initialize(string id, string vendor, string model, Vector2 pos, Vector2 direction, int altitude, int speed, int maxSpeed, int acceleration)
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
            this.game = this.map.getGame();
            this.icon = this.game.icons["AirbusA380"];
        }
        public void Update()
        {
            //Calculate new pos with speed and acceleration
            if (this.speed < this.maxSpeed)
            {
                this.speed = this.speed * this.acceleration / 10 + this.speed;
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
            if (drawInfo)
            {
                spriteBatch.DrawString(this.map.getGame().defaultFont, "SPEED: " + this.speed.ToString() + " u/s", drawPos + new Vector2(0, -20), Color.Black);
                spriteBatch.DrawString(this.map.getGame().defaultFont, "COORDINATES: " + this.pos.X + ", " + this.pos.Y, drawPos + new Vector2(0, -40), Color.Black);
                spriteBatch.DrawString(this.map.getGame().defaultFont, this.vendor + " " + this.model + " - " + this.id, drawPos + new Vector2(0, -60), Color.Black);
            }
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
    }
}
