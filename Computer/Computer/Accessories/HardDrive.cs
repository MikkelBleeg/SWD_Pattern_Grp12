﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer.Accessories
{
    public class HardDrive : IComputer
    {
        public HardDrive(IComputer computer) : base(computer)
        {
        }
        /*
        public override double GetCost()
        {
            return Computer.GetCost() + cost;
        }

        public override string GetAccessories()
        {
            return Car.GetAccessories() + ", processor";
        }
        */
    }
}
