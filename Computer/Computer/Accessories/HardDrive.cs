﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class HardDrive : ComputerDecorator
    {
        public HardDrive(IComputer computer) : base(computer)
        {
        }
        
        public override double GetCost()
        {
            return Computer.GetCost() + 5000;
        }

        public override string GetAccessories()
        {
            return Computer.GetAccessories() + ", 2T Hard drive";
        }
        
    }
}
