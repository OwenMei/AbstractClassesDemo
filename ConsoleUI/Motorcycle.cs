using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {
        public bool hasSideCart { get; set; }

        public override void driveAbstract()
        {
            Console.WriteLine($"Vroom Vroom, this is a {make} {model} {year}. AND ... it {((hasSideCart)? "has" : "does not have")} a side cart");
        }

        public override void driveVirtual()
        {
            Console.WriteLine("Something about a virtual drive, this is motorcycles btw");
        }

    }
}
