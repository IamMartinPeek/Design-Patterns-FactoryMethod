using System;
using System.Collections.Generic;
using System.Text;
using FactoryMethod.ComputerComponents;

namespace FactoryMethod.ComputerTypes
{
    public class GamingLaptop : Computer
    {
        //factory method
        protected override void AddComponents()
        {
            Components.Add(new Display());
            Components.Add(new Speaker());
            Components.Add(new Accumulator());
            Components.Add(new GraphicsCard());
        }
    }
}
