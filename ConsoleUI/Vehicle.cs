using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    abstract class Vehicle
    {
        public int Year { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }

        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine("virtual drive? what is that? This is the default driveVirtual in Vehicle class");
        }


    }
}
