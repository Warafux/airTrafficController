using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTrafficController
{
    public class stats
    {
        private int deadPeopleCounter = 0;
        private List<string> deadPeopleLog = new List<string>();

        public void addDeadPeople(string logMessage, int quantity)
        {
            this.deadPeopleCounter += Math.Abs(quantity);
            this.deadPeopleLog.Add(logMessage);
        }
        public int getDeadPeople()
        {
            return this.deadPeopleCounter;
        }
        public List<String> getDeadPeopleLog()
        {
            return this.deadPeopleLog;
        }
    }
}
