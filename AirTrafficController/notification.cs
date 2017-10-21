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
        private int startTime = 0;
        private int endTime = 0;

        public notification(Game1 game, string message, int endTime)
        {
            this.message = message;
            this.game = game;
            this.endTime = endTime;
            this.startTime = (int)game.gameTime.TotalGameTime.Seconds;
        }
        public notification(Game1 game, string message)
        {
            this.message = message;
            this.game = game;
            this.endTime = notificationsManager.defaultNotificationTime;
            this.startTime = (int)game.gameTime.TotalGameTime.Seconds;
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
            spriteBatch.DrawString(game.defaultFont, (this.endTime - game.gameTime.TotalGameTime.Seconds).ToString(), pos + new Vector2(-100 + size.X, 0), Color.Black);
        }
        public void setEndTime(int time)
        {
            this.endTime = time;
        }
        public int getEndTime()
        {
            return this.endTime;
        }
    }
}
