using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Accessories
{
    public class Screen : ComputerDecorator
    {
        public Screen(IComputer computer) : base(computer)
        {
        }
        
        public override double GetCost()
        {
            return Computer.GetCost() + 4000;
        }

        public override string GetAccessories()
        {
            return Computer.GetAccessories() + ", Retina Display with True Tone";
        }
        
    }
}
