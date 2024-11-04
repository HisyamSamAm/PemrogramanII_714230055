using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714230055
{
    internal class Program
    {
        static void Main()
        {
            WarnetManager warnetManager = new WarnetManager();

            warnetManager.AddComputer(new GamingStation(1));
            warnetManager.AddComputer(new OfficeStation(2));

            bool running = true;
            while (running)
            {
                Console.WriteLine("\nSistem Manajemen Warnet");
                Console.WriteLine("1. Mulai Penggunaan");
                Console.WriteLine("2. Akhiri Penggunaan");
                Console.WriteLine("3. Tampilkan Status Semua Komputer");
                Console.WriteLine("4. Keluar");
                Console.Write("Pilih opsi: ");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.Write("Masukkan ID Komputer untuk memulai penggunaan: ");
                        int startID = int.Parse(Console.ReadLine());
                        warnetManager.StartUsage(startID);
                        break;
                    case "2":
                        Console.Write("Masukkan ID Komputer untuk mengakhiri penggunaan: ");
                        int endID = int.Parse(Console.ReadLine());
                        warnetManager.EndUsage(endID);
                        break;
                    case "3":
                        warnetManager.DisplayAllComputers();
                        break;
                    case "4":
                        running = false;
                        Console.WriteLine("Keluar dari program...");
                        break;
                    default:
                        Console.WriteLine("Opsi tidak valid. Silakan coba lagi.");
                        break;
                }
            }
        }
    }
}
