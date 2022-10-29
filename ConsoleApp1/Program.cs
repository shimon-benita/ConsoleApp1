using ConsoleApp1.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main()
        {
            var menash = new Person
            {
                firstName = "Menash",
                lastName = "Ben Ita"
            };

            menash.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);
                

        }

    }
}