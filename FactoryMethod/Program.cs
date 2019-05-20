using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.ComputerTypes;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer a = new BusinessLaptop();
            Computer b = new GamingLaptop();
            Computer c = new PC();

            Console.WriteLine("Business Laptop: " + a.ComputerComponentsString);
            Console.WriteLine("Gaming Laptop: " + b.ComputerComponentsString);
            Console.WriteLine("PC: " + c.ComputerComponentsString);

            Console.ReadLine();
       
        }
    }
}
