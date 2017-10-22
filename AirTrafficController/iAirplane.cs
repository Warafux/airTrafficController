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
        void Update();
        void Draw(SpriteBatch spriteBatch);
        void Initialize(string id, string vendor, string model, Vector2 pos, Vector2 direction, int altitude, int speed, int maxSpeed, int acceleration);

        //Getters
        Vector2 getPos();
        void setPos(Vector2 pos);
        string getId();
        void click();
    }
}
