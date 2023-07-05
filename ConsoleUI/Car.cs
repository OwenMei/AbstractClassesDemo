using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Car : Vehicle
    {
        public bool hasTrunk { get; set; }

        public override void driveAbstract()
        {
            Console.WriteLine($"Kchuck Kchuck, this is a {make} {model} {year}. AND ... it {((hasTrunk) ? "has" : "does not have")} a trunk");
        }

    }
}
