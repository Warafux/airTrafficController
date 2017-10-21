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

        private string brand = "";
        private string model = "";
        private string id = "";
        private Vector2 pos;
        private int altitude = 0;

        public airplane()
        {
            Random random = new Random();
            this.pos = new Vector2(random.Next(1, 999), random.Next(1, 999));
        }
        public void Initialize(Texture2D texture, Vector2 pos)
        {
            this.texture = texture;
            this.pos = pos;
        }
        public void Update()
        {
            
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(this.texture, this.pos, null, Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0f);
        }
        public Vector2 getPos()
        {
            return this.pos;
        }
        public void setPos(Vector2 pos)
        {
            this.pos = pos;
        }
    }
}
