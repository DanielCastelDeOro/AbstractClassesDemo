using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public int year { get; set; } = 1;
        public string make { get; set; } = "Default make";
        public string model { get; set; } = "Default model";
        public abstract void DriveAbstract();
        public virtual void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} is virtually in Drive");
        }
       


    }
    
}
