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
        void Initialize(string id, string vendor, string model, Vector2 pos, Vector2 direction, int altitude, int speed, int maxSpeed, int acceleration, int capacity);

        //Getters
        Vector2 getPos();
        Vector2 getDrawPos();
        string getId();
        string getVendor();
        string getModel();
        int getCapacity();
        int getMaxSpeed();
        bool getCollisionDanger();

        //Setters
        void setPos(Vector2 pos);
        void setDrawInfo(bool drawInfo);
        void switchDrawInfo();
        void setCollisionDanger(bool collisionDanger);
        void addCollisionDangerWith(iAirplane airplane);
        void removeAllCollisionDangerWith();
        //Other
        void click();
        void hover(bool isHovering);
    }
}
