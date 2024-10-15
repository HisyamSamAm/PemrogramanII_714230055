using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_1_714230055
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Masukan angka pertama:");
            double input1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Masukan angka kedua:");
            double input2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Angka Pertama = " + input1);
            Console.WriteLine("Angka ke2 = " + input2);
            Console.WriteLine(input1 + " + " + input2 + " = " + (input1 + input2));
            Console.WriteLine(input1 + " - " + input2 + " = " + (input1 - input2));
            Console.WriteLine(input1 + " * " + input2 + " = " + (input1 * input2));
            Console.WriteLine(input1 + " / " + input2 + " = " + (input1 / input2));


        }
    }
}
