using System;
using System.Collections.Generic;
using System.Text;
using FactoryMethod.ComputerComponents;

namespace FactoryMethod.ComputerTypes
{
    public class PC : Computer
    {
        //factory method
        protected override void AddComponents()
        {
            Components.Add(new GraphicsCard());
        }
    }
}
