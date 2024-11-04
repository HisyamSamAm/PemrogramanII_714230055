using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714230055
{
    public class WarnetManager
    {
        private readonly List<ComputerStation> computers = new List<ComputerStation>();

        public void AddComputer(ComputerStation computer)
        {
            computers.Add(computer);
            Console.WriteLine($"Komputer dengan ID {computer.StationID} berhasil ditambahkan!");
        }

        public void StartUsage(int stationID)
        {
            var computer = computers.Find(c => c.StationID == stationID);
            if (computer != null && computer.Status == "Tersedia")
            {
                computer.StartUsage();
                Console.WriteLine($"Komputer dengan ID {stationID} sekarang sedang digunakan.");
            }
            else
            {
                Console.WriteLine($"Komputer dengan ID {stationID} tidak tersedia.");
            }
        }

        public void EndUsage(int stationID)
        {
            var computer = computers.Find(c => c.StationID == stationID);
            if (computer != null && computer.Status == "Sedang Digunakan")
            {
                computer.EndUsage();
                double cost = computer.CalculateCost();
                Console.WriteLine($"Penggunaan komputer dengan ID {stationID} telah berakhir. Total biaya: Rp {cost:N0}");
            }
            else
            {
                Console.WriteLine($"Komputer dengan ID {stationID} tidak sedang digunakan.");
            }
        }

        public void DisplayAllComputers()
        {
            Console.WriteLine("Status Komputer:");
            foreach (var computer in computers)
            {
                Console.WriteLine($"Komputer ID {computer.StationID}: {computer.Status}");
            }
        }
    }
}
