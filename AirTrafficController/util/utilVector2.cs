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
        public static Vector2 getRandomDirection()
        {
            Random random = new Random();
            Vector2 ret = new Vector2(-1, 0);
            switch (random.Next(1, 4))
            {
                case 1:
                    ret = new Vector2(1, 0);
                    break;
                case 2:
                    ret = new Vector2(0, -1);
                    break;
                case 3:
                    ret = new Vector2(0, 1);
                    break;
                default:
                    break;
            }
            return ret;
        }
    }
}
