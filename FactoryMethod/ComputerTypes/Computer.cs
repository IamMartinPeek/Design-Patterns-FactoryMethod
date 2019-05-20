using System;
using System.Collections.Generic;
using System.Text;
using FactoryMethod.ComputerComponents;

namespace FactoryMethod.ComputerTypes
{
    public abstract class Computer
    {
        List<ComputerComponent> _Components = new List<ComputerComponent>();
        public List<ComputerComponent> Components { get => _Components; }

        protected Computer()
        {
            //every computer needs at least a motherboard, ram and a processor
            _Components.Add(new Motherboard());
            _Components.Add(new Ram());
            _Components.Add(new Processor());
            AddComponents();
        }

        //actual factory method
        protected abstract void AddComponents();

        public string ComputerComponentsString
        {
            get
            {
                string components = "";
                foreach(ComputerComponent cc in _Components)
                {
                    components += cc.GetType().Name + ", ";
                }
                return components;
            }
        }



    }
}
