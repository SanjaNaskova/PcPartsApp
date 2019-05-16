using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Classes
{
    public class NumberExeption2: Exception
    {
        public int NumInput { get; set; }

        public NumberExeption2(int numInput)
        {
            NumInput = numInput;
        }

        public void PrintError2()
        {
            Console.WriteLine($"Your input {NumInput} is not a valid choice.");
            Console.WriteLine("Please choose one of the numbers given for option.");
            Console.WriteLine("Extra information: ");
            Console.WriteLine($"Source: {base.Source}");
            Console.WriteLine($"Target: {base.TargetSite}");
            Console.WriteLine($"Trace: {base.StackTrace}");
        }
    }
}
