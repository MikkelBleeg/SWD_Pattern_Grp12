using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public abstract class ComputerDecorator : IComputer
    {
        protected IComputer Computer;

        protected ComputerDecorator(IComputer computer)
        {
            Computer = computer;
        }

        public virtual double GetCost()
        {
            return Computer.GetCost();
        }

        public virtual string GetAccessories()
        {
            return Computer.GetAccessories();
        }
    }
}
