using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Accessories
{
    public class Processor : ComputerDecorator
    {
        public Processor(IComputer computer) : base(computer)
        {
        }
        
        public override double GetCost()
        {
            return Computer.GetCost() + 2990;
        }

        public override string GetAccessories()
        {
            return Computer.GetAccessories() + ", Intel Core i7 processor";
        }
        
    }
}
