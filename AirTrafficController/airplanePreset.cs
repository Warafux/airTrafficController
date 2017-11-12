using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTrafficController
{
    public class airplanePreset : iAirplanePreset
    {
        private string vendor = "";
        private string model = "";
        private int capacity = 0;
        private int maxSpeed = 0;
        private string iconName = "";
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
        public int getMaxSpeed()
        {
            return this.maxSpeed;
        }
        public string getIconName()
        {
            return this.iconName;
        }
        public void Initialize(string vendor, string model, int capacity, int maxSpeed, string iconName)
        {
            this.vendor = vendor;
            this.model = model;
            this.capacity = capacity;
            this.maxSpeed = maxSpeed;
            this.iconName = iconName;
        }
    }
}
