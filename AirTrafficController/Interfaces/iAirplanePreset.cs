using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTrafficController
{
    public interface iAirplanePreset
    {
        string getVendor();
        string getModel();
        string getIconName();
        int getCapacity();
        int getMaxSpeed();
        void Initialize(string vendor, string model, int capacity, int maxSpeed, string iconName);
    }
}
