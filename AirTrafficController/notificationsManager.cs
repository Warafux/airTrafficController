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
        private List<notification> notifications = new List<notification>();
        public notificationsManager(Game1 game)
        {
            this.game = game;
        }
        public void addNotification(string message)
        {
            addNotification(new notification(game, message), notificationsManager.defaultNotificationTime);
        }
        public void addNotification(string message, int notificationTime)
        {
            addNotification(new notification(game, message), notificationTime);
        }
        public void addNotification(notification notification, int notificationTime)
        {
            notification.setEndTime(notificationTime + game.gameTime.TotalGameTime.Seconds);
            notifications.Add(notification);

            Console.WriteLine("NOTIFICATION ADDED!");
        }
        public void addNotification(notification notification)
        {
            this.addNotification(notification, notificationsManager.defaultNotificationTime);
        }
        public void Update()
        {
            foreach (notification notification in this.notifications)
            {

                if(notification.getEndTime() < game.gameTime.TotalGameTime.Seconds)
                {
                    notifications.Remove(notification);
                    break;
                }
            }
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            int i = 1;
            Vector2 screenSize = game.Window.ClientBounds.Size.ToVector2();
            foreach (notification notification in this.notifications)
            {
                Vector2 notificationPos = new Vector2(0, screenSize.Y - 30 * i);
                Vector2 notificationSize = new Vector2(screenSize.X - 2, 30 - 2);

                notification.Draw(spriteBatch, notificationPos, notificationSize);
                i++;
            }
        }
    }
}
