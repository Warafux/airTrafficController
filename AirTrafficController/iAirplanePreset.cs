using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTrafficController
{
    interface iAirplanePreset
    {
        string getVendor();
        string getModel();
        int getCapacity();
    }
}
