using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714230055
{
    public class OfficeStation : ComputerStation
    {
        public OfficeStation(int stationID) : base(stationID, 3000) { }

        public override double CalculateCost()
        {
            var duration = (EndTime - StartTime).TotalHours;
            return duration * HourlyRate;
        }
    }
}
