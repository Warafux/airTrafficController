using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTrafficController
{
    public class map
    {
        private Game1 game;
        private Point size;
        public Point pos;

        private List<iAirplane> airplanes = new List<iAirplane>();

        //DRAW PROPERTIES
        private int spaceBetweenXGrid = 2;
        private int spaceBetweenYGrid = 10;

        public map(Game1 game, int xPos, int yPos, int width, int height)
        {
            this.game = game;
            this.pos = new Point(xPos, yPos);
            this.size = new Point(width, height);
        }
        public void addAirplane(iAirplane airplane)
        {

        }
        public void Draw(SpriteBatch spriteBatch)
        {
            utilDraw.drawRectangle(spriteBatch, game.lineTexture, new Rectangle(pos, size), Color.Black);
            foreach(iAirplane airplane in airplanes)
            {
                airplane.Draw(spriteBatch);
            }
        }
    }
}
