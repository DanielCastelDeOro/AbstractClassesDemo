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
             *Done- Create an abstract class called Vehicle
             * Done- The vehicle class shall have three string properties Year, Make, and Model
             * Done- Set the defaults to something generic in the Vehicle class
             * Done_Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Done- Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Done- Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Done- Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             *Done- Only in the Motorcycle class will you override the virtual drive method
            */

            // Done- Create a list of Vehicle called vehicles
            var vehicles = new List<Vehicle>();
            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */
            var Nisan = new Car() { hasTruck = true, year = 2021, make = "Nissan", model = "GTR"};
            var Honda = new Motorcycle() { HasSideCart = true, year = 2021, make = "Honda", model = "1000RR" };
            Vehicle BMW = new Car() { year = 2021, hasTruck = true, make = "BMW", model ="3series"};
            Vehicle Suburu = new Car() { hasTruck = true, year = 2020, make = "Suburu", model = "Forester" };
            Vehicle HD = new Motorcycle() { HasSideCart = false, year = 2012, make = "HD", model = "Fat Boy" };
            vehicles.Add(Nisan);
            vehicles.Add(Honda);
            vehicles.Add(HD);
            vehicles.Add(BMW);
            vehicles.Add(Suburu);
            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */
            //foreach (var veh in vehicles)
            //{

            //    Console.WriteLine($"Make: {veh.make} Model: {veh.model} Year: {veh.year}");
            //    veh.DriveAbstract();
            //    Console.WriteLine("-------------------------");
            //}
            foreach (var newVeh in vehicles)
            {
                Console.WriteLine($"Year: {newVeh.year} Make: {newVeh.make} Model: {newVeh.model}");
                newVeh.DriveAbstract();
                Console.WriteLine("-----------------------");
            }
            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
