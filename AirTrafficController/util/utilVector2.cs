using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTrafficController.util
{
    public class utilVector2
    {
        public static Dictionary<string, Vector2> availableDirections = new Dictionary<string, Vector2>() {
            {"Left", new Vector2(-1, 0)},
            {"Right", new Vector2(1, 0)},
            {"Up", new Vector2(0, -1)},
            {"Down", new Vector2(0, 1)},

        };
        //Default values
        public static Vector2 defaultDirection = new Vector2(1, 0);
        public static string defaultDirectionName = "Right";

        public static Vector2 getRandomDirection()
        {
            Random random = new Random();
            return utilVector2.availableDirections.ElementAt(random.Next(0, utilVector2.availableDirections.Count)).Value;
        }

        public static Vector2 getDirectionFromString(string directionString)
        {
            return utilVector2.availableDirections.ContainsKey(directionString) ? utilVector2.availableDirections[directionString] : utilVector2.defaultDirection;
        }
        public static string getStringFromDirection(Vector2 direction)
        {
            //Source https://stackoverflow.com/a/2444064/6832219
            return utilVector2.availableDirections.ContainsValue(direction) ? utilVector2.availableDirections.First(x => x.Value == direction).Key : utilVector2.defaultDirectionName;
        }
        public static float angleOfDirection(Vector2 direction)
        {
            return MathHelper.ToDegrees((float)Math.Atan2((double)direction.X, (double)direction.Y));
        }
    }
}
