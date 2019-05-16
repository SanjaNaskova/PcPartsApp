using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Classes
{
   public class IdExeption :Exception
    {
        public int IdInput { get; set; }

        public IdExeption(int idInput)
        {
            IdInput = idInput;
        }

        public void PrintIdExeption()
        {
            Console.WriteLine($"There is no product with the entered Id number {IdInput}");
            Console.WriteLine("Please choose a valid ID number from the given options.");
        }

    }
}
