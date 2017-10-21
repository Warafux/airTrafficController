using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTrafficController
{
    public class notification
    {
        private string message = "";
        private Game1 game;

        public notification(Game1 game, string message)
        {
            this.message = message;
            this.game = game;
        }
        public string getMessage()
        {
            return message;
        }
        public void Draw(SpriteBatch spriteBatch, Vector2 pos, Vector2 size)
        {
            //utilDraw.drawRectangle(spriteBatch, game.lineTexture, new Rectangle(pos.ToPoint(), size.ToPoint()), Color.Red);
            utilDraw.drawRectangle(spriteBatch, game.lineTexture, new Rectangle(pos.ToPoint(), size.ToPoint()), Color.Black);
            spriteBatch.DrawString(game.defaultFont, this.message, pos + new Vector2(10, 10), Color.Black);
        }
    }
}
