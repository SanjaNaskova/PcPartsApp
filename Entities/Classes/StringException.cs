using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Classes
{
   public class StringException: Exception
    {
        public string StringInput { get; set; }

        public StringException(string stringInput)
        {
            StringInput = stringInput;
        }

        public void PrintStringException()
        {
            Console.WriteLine($"There is no type with that name: {StringInput}");
           
        }

    }
}
