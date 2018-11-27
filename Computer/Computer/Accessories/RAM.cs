using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class RAM : ComputerDecorator
    {
        public RAM(IComputer computer) : base(computer)
        {
        }
        
        public override double GetCost()
        {
            return Computer.GetCost() + 600;
        }

        public override string GetAccessories()
        {
            return Computer.GetAccessories() + ", 16GB 2400MHz DDR4 Memory";
        }
        
    }
}
