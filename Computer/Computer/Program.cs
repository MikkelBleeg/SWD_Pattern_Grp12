using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Accessories;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("15-inch MacBook Pro");
            IComputer MacBook = new HardDrive(new Processor(new RAM(new Screen( new Touchpad(new MacbookPro())))));

            Console.WriteLine("{0:C}",MacBook.GetCost());
            Console.WriteLine(MacBook.GetAccessories());

            Console.WriteLine("\nMacBook Pro - If you want to afford food");
            IComputer cheapMacBook = new Screen(new Touchpad(new MacbookPro()));

            Console.WriteLine("{0:C}", cheapMacBook.GetCost());
            Console.WriteLine(cheapMacBook.GetAccessories());
        
        }
    }
}
