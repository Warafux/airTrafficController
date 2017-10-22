using AirTrafficController.util;
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
        public Texture2D texture;
        private string vendor = "";
        private string model = "";
        private string id = "";
        private Vector2 pos;
        private int altitude = 0;
        private int speed;
        private int acceleration;
        private Vector2 direction;
        private map map;

        private bool drawInfo = true;

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
        public void Initialize(string id, string vendor, string model, Vector2 pos, Vector2 direction, int altitude, int speed, int acceleration)
        {
            this.id = id;
            this.vendor = vendor;
            this.model = model;
            this.pos = pos;
            this.direction = direction == Vector2.Zero ? utilVector2.getRandomDirection() : direction;
            this.altitude = altitude;
            this.speed = speed;
            this.acceleration = acceleration;
        }
        public void Update()
        {
            //Calculate new pos with speed and acceleration
            int newSpeed = this.speed * this.acceleration;
            Vector2 newPos = new Vector2(
                this.direction.X * this.speed + this.pos.X,
                this.direction.Y * this.speed + this.pos.Y
                );
            this.pos = newPos;
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            //Calculate pos to draw inside the map
            Vector2 drawPos = new Vector2(
                utilDraw.convertRange(0, (int)this.map.getSize().X, 0, this.map.getGame().GraphicsDevice.Viewport.Width, (int)this.pos.X),
                utilDraw.convertRange(0, (int)this.map.getSize().Y, 0, this.map.getGame().GraphicsDevice.Viewport.Height, (int)this.pos.Y)
                );
            //spriteBatch.Draw(this.map.getGame().lineTexture, drawPos, null, Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0f);
            spriteBatch.DrawString(this.map.getGame().defaultFont, "XD", drawPos, Color.Black);
            if (drawInfo)
            {
                spriteBatch.DrawString(this.map.getGame().defaultFont, this.speed.ToString(), drawPos, Color.Black);
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
    }
}
