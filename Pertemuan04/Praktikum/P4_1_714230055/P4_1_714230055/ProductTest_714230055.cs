using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_714230055
{
    class ProductTest_714230055
    {
        static void Main(string[] args)
        {
            /*Product_714230055 myProduct = new Product_714230055();
            myProduct.MyType = "DVD";
            Console.WriteLine(myProduct.MyType);*/

            Book_714230055 product1 = new Book_714230055("Book", "C# Object Orientasi Solution", "300");
            DVD_714230055 product2 = new DVD_714230055("Ethernal Sunshine of the spotles mind", "145");
            product1.DisplayInfo();
            product2.DisplayInfo();
        }
    }
}
