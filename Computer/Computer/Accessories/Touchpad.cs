using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Touchpad : ComputerDecorator
    {
        public Touchpad(IComputer computer) : base(computer)
        {
        }
        
        public double GetCost()
        {
            return Computer.GetCost() + 138;
        }

        public override string GetAccessories()
        {
            return Computer.GetAccessories() + ", touchpad";
        }
        
    }


}
