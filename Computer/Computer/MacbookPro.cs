using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class MacbookPro : IComputer
    {
        public double GetCost()
        {
            return 15800;
        }

        
        public string GetAccessories()
        {
            return "15-inch MacBook Pro";
        }
        
    }
}
