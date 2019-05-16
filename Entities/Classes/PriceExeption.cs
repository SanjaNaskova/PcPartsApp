using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Classes
{
   public class PriceExeption: Exception
    {
        public double PriceInput { get; set; }

        public PriceExeption(double priceInput)
        {
            PriceInput = priceInput;
        }

        public void PrintPriceExeption()
        {
            Console.WriteLine($"There is no product with that price ${PriceInput}.");
            Console.WriteLine("For PARTS: min price is $8");
            Console.WriteLine("For MODULES min price is $100");
            Console.WriteLine("For CONFIGURATIONS min price is $200");
        }
    }
}
