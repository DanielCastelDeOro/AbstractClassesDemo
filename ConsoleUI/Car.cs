﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
   public class Car : Vehicle
    {
        public bool hasTruck { get; set; } = true;
        public override void DriveAbstract()
        {
            Console.WriteLine("This car is in Drive");
        }

    }
}
