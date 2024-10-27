using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_2_714230055
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continueApp = true;

            while (continueApp)
            {
                Console.Clear();
                Console.WriteLine("=== MENU PERSEGI PANJANG ===");
                Console.WriteLine("1. Hitung Luas");
                Console.WriteLine("2. Hitung Keliling");
                Console.WriteLine("3. Keluar");
                Console.Write("Pilihan menu (1-3): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        CalculateArea();
                        break;
                    case "2":
                        CalculatePerimeter();
                        break;
                    case "3":
                        continueApp = false;
                        Console.WriteLine("Program selesai.");
                        Console.WriteLine("Terima kasih!");
                        break;
                    default:
                        Console.WriteLine("Menu tidak tersedia. Silahkan pilih menu yang valid.");
                        break;
                }

                if (continueApp)
                {
                    Console.Write("Ingin mengulang kembali (Y/T)? ");
                    string backToMenu = Console.ReadLine();
                    if (backToMenu.ToUpper() != "Y")
                    {
                        continueApp = false;
                        Console.WriteLine("Terima kasih!");
                    }
                }
            }
        }

        static void CalculateArea()
        {
            Console.Write("Masukkan panjang: ");
            double length = double.Parse(Console.ReadLine());
            Console.Write("Masukkan lebar: ");
            double width = double.Parse(Console.ReadLine());

            double area = length * width;
            Console.WriteLine($"Luas Persegi Panjang: {area}");
        }

        static void CalculatePerimeter()
        {
            Console.Write("Masukkan panjang: ");
            double length = double.Parse(Console.ReadLine());
            Console.Write("Masukkan lebar: ");
            double width = double.Parse(Console.ReadLine());

            double perimeter = 2 * (length + width);
            Console.WriteLine($"Keliling Persegi Panjang: {perimeter}");
        }
    }
}
