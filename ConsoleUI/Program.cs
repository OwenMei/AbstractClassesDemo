using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties with object initializer syntax
             */

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            // Call each of the drive methods for one car and one motorcycle

            List<Vehicle> vehicles = new List<Vehicle>();

            Car toyota = new Car() { model = "camry", make = "Toyota", year = 2023, hasTrunk = true};
            Vehicle honda = new Car() { model = "Odyssey", make = "Honda", year = 2023, hasTrunk = true };
            Motorcycle kawasaki = new Motorcycle() { model = "Ninja 250", make = "Kawasaki", year = 1986, hasSideCart = false };
            Vehicle ducati = new Motorcycle() { model = "Fort MFG", make = "Ducati", year = 2019, hasSideCart = true };

            vehicles.Add(toyota);
            vehicles.Add(honda);
            vehicles.Add(ducati);
            vehicles.Add(kawasaki);

            foreach(Vehicle automobile in vehicles)
            {
                automobile.driveAbstract();
                automobile.driveVirtual();
            }

            #endregion            
            Console.ReadLine();
        }
    }
}
