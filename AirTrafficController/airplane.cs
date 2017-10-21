using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTrafficController
{
    class airplane : iAirplane
    {
        public Texture2D texture;

        private Vector2 pos;

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
