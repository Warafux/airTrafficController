using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTrafficController
{
    class notificationsManager
    {
        public const int defaultNotificationTime = 2;
        private Game1 game;
        private List<KeyValuePair<notification, int>> notifications = new List<KeyValuePair<notification, int>>();
        public notificationsManager(Game1 game)
        {
            this.game = game;
        }
        public void addNotification(notification notification, int notificationTime)
        {
            notifications.Add(new KeyValuePair<notification, int>(notification, (notificationTime + game.gameTime.TotalGameTime.Seconds)));
            Console.WriteLine("NOTIFICATION ADDED!");
        }
        public void addNotification(notification notification)
        {
            this.addNotification(notification, notificationsManager.defaultNotificationTime);
        }
        public void Update()
        {
            foreach (KeyValuePair<notification, int> notificationRow in this.notifications)
            {
                notification notification = notificationRow.Key;
                int time = notificationRow.Value;
                if(time < game.gameTime.TotalGameTime.Seconds)
                {
                    notifications.Remove(notificationRow);
                    break;
                }
            }
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            int i = 1;
            Vector2 screenSize = game.Window.ClientBounds.Size.ToVector2();
            foreach (KeyValuePair<notification, int> notificationRow in this.notifications)
            {
                notification notification = notificationRow.Key;
                int time = notificationRow.Value;

                Vector2 notificationPos = new Vector2(0, screenSize.Y - 30 * i);
                Vector2 notificationSize = new Vector2(screenSize.X - 2, 30 - 2);

                notification.Draw(spriteBatch, notificationPos, notificationSize);
                i++;
            }
        }
    }
}
