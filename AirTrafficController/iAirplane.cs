using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTrafficController
{
    public interface iAirplane
    {
        //Properties

        //Methods
        void Initialize(Texture2D texture, Vector2 pos);
        void Update();
        void Draw(SpriteBatch spriteBatch);
        Vector2 getPos();
        void setPos(Vector2 pos);
    }
}
