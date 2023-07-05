using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    abstract class Vehicle
    {
        public int year { get; set; }
        public string model { get; set; }
        public string make { get; set; }

        public abstract void driveAbstract();

        public virtual void driveVirtual()
        {
            Console.WriteLine("virtual drive? what is that? This is the default driveVirtual in Vehicle class");
        }


    }
}
