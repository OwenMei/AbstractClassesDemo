using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {
        public bool HasSideCart { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine($"Vroom Vroom, this is a {Make} {Model} {Year}. AND ... it {((HasSideCart)? "has" : "does not have")} a side cart");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("Something about a virtual drive, this is motorcycles btw");
        }

    }
}
