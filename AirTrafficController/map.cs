using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTrafficController
{
    public class map
    {
        private Game1 game;
        private Vector2 size;
        public Vector2 pos;

        private List<iAirplane> airplanes = new List<iAirplane>();
        //DRAW PROPERTIES

        public map(Game1 game, Vector2 pos, Vector2 size)
        {
            this.game = game;
            this.pos = pos;
            this.size = size;
        }
        public void addAirplane(iAirplane airplane)
        {
            if (!existIdInMap(airplane.getId()))
            {
                airplanes.Add(airplane);
            }
        }
        public void Update(GameTime gameTime)
        {
            foreach (iAirplane airplane in airplanes)
            {
                airplane.Update();

                if (!isValidAirplanePos(airplane))
                {
                    Console.WriteLine("INVALID POS, REMOVING");
                    airplanes.Remove(airplane);
                    break;
                }
            }
        }
        private bool isValidAirplanePos(iAirplane airplane)
        {
            Vector2 airplanePos = airplane.getPos();
            return (airplanePos.X < this.size.X && airplanePos.X >= 0) && (airplanePos.Y < this.size.Y && airplanePos.Y >= 0);
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            //We calculate the area of the window
            Vector2 drawSize = new Vector2(game.GraphicsDevice.Viewport.Width - 2, game.GraphicsDevice.Viewport.Height - 2);
            utilDraw.drawRectangle(spriteBatch, game.lineTexture, new Rectangle(pos.ToPoint(), drawSize.ToPoint()), Color.Black);
            foreach(iAirplane airplane in airplanes)
            {
                airplane.Draw(spriteBatch);
            }
        }
        public Vector2 getSize()
        {
            return this.size;
        }
        public Game1 getGame()
        {
            return this.game;
        }
        public List<iAirplane> getAirplanes()
        {
            return airplanes;
        }
        public bool existIdInMap(string id)
        {
            foreach (iAirplane airplane in airplanes)
            {
                if(airplane.getId() == id)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
