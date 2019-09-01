using System;
using example01.Mediator;

namespace example01.Component
{
    public class PowerSupplier : IPowerSupplier
    {
        public PowerSupplier(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public void TurnOn()
        {
            Console.WriteLine("Component {0} Turning On...", Name);
        }

        public void TurnOff()
        {
            Console.WriteLine("Component {0} Turning Off...", Name);
        }
    }
}