using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714230055
{
    public abstract class ComputerStation
    {
        public int StationID { get; private set; }
        public string Status { get; protected set; } = "Tersedia";
        public double HourlyRate { get; protected set; }
        protected DateTime StartTime;
        protected DateTime EndTime;

        public ComputerStation(int stationID, double hourlyRate)
        {
            StationID = stationID;
            HourlyRate = hourlyRate;
        }

        public void StartUsage()
        {
            Status = "Sedang Digunakan";
            StartTime = DateTime.Now;
        }

        public void EndUsage()
        {
            Status = "Tersedia";
            EndTime = DateTime.Now;
        }

        public abstract double CalculateCost();
    }
}
