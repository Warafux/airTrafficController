﻿using AirTrafficController.util;
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
        public airplane(map map)
        {
            Random random = new Random();
            this.pos = new Vector2(random.Next(1, 999), random.Next(1, 999));
            this.speed = random.Next(1, 20);
            this.acceleration = random.Next(1, 5);

            this.direction = utilVector2.getRandomDirection();

            Vector2 drawPos = new Vector2(
                utilDraw.convertRange(0, (int)map.getSize().X, 0, map.getGame().GraphicsDevice.Viewport.Width, (int)this.pos.X),
                utilDraw.convertRange(0, (int)map.getSize().Y, 0, map.getGame().GraphicsDevice.Viewport.Height, (int)this.pos.Y)
                );
           // Console.WriteLine(drawPos.ToString());
            //Console.WriteLine("MAP SIZE: " + map.getSize().ToString());
            //Console.WriteLine("WINDOW SIZE: " + map.getGame().GraphicsDevice.Viewport.Width + " , " + map.getGame().GraphicsDevice.Viewport.Height);
        }
        public void Initialize(Texture2D texture, Vector2 pos)
        {
            this.texture = texture;
            this.pos = pos;
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
        public void Draw(SpriteBatch spriteBatch, map map)
        {
            //Calculate pos to draw inside the map
            Vector2 drawPos = new Vector2(
                utilDraw.convertRange(0, (int)map.getSize().X, 0, map.getGame().GraphicsDevice.Viewport.Width, (int)this.pos.X),
                utilDraw.convertRange(0, (int)map.getSize().Y, 0, map.getGame().GraphicsDevice.Viewport.Height, (int)this.pos.Y)
                );
            spriteBatch.Draw(map.getGame().lineTexture, drawPos, null, Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0f);
            spriteBatch.DrawString(map.getGame().defaultFont, "XD", drawPos, Color.Black);
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
    }
}
