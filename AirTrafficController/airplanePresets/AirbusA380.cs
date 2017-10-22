using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTrafficController.airplanePresets
{
    class AirbusA380 : iAirplanePreset
    {
        private string vendor = "Airbus";
        private string model = "A380";
        private int capacity = 200;
        public string getVendor()
        {
            return this.vendor;
        }
        public string getModel()
        {
            return this.model;
        }
        public int getCapacity()
        {
            return this.capacity;
        }
    }
}
