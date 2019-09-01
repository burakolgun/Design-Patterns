using System;
using example01.Mediator;

namespace example01.Fan
{
    public class Fan : IFan
    {
        private bool _power;

        public Fan()
        {
            _power = false;
        }

        public void TurnOn()
        {
            if (IsOn()) return;
            _power = true;
            Console.WriteLine("Fan shutting up ...");
            
        }

        public void TurnOff()
        {
            if (!IsOn()) return;
            _power = false;
            Console.WriteLine("Fan shutting down ...");
        }

        public bool IsOn()
        {
            return _power;
        }
    }
}