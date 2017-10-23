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
        Vector2 getDrawPos();
        void setPos(Vector2 pos);
        void setDrawInfo(bool drawInfo);
        void switchDrawInfo();
        string getId();
        void click();
        void hover(bool isHovering);
    }
}
