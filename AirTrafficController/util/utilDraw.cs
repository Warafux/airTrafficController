using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTrafficController
{
    class utilDraw
    {
        public static void drawRectangle(SpriteBatch spriteBatch, Texture2D rectangleTexture, Rectangle rectangle, Color color)
        {
            spriteBatch.Draw(rectangleTexture, new Rectangle(rectangle.Left, rectangle.Top, rectangle.Width, 1), color);
            spriteBatch.Draw(rectangleTexture, new Rectangle(rectangle.Left, rectangle.Bottom, rectangle.Width, 1), color);
            spriteBatch.Draw(rectangleTexture, new Rectangle(rectangle.Left, rectangle.Top, 1, rectangle.Height), color);
            spriteBatch.Draw(rectangleTexture, new Rectangle(rectangle.Right, rectangle.Top, 1, rectangle.Height + 1), color);
        }
    }
}
