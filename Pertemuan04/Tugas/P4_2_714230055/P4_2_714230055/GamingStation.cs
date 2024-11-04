using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714230055
{
    public class GamingStation : ComputerStation
    {
        public GamingStation(int stationID) : base(stationID, 5000) { }

        public override double CalculateCost()
        {
            var duration = (EndTime - StartTime).TotalHours;
            return duration * HourlyRate;
        }
    }
}
