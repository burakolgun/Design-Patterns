using example01.Component;
using example01.Fan;

namespace example01.Mediator
{
    public class ConcreteMediator : Mediator
    {
        private readonly IFan _fan;
        private readonly IPowerSupplier _powerSupplier;

        public ConcreteMediator(IFan fan, PowerSupplier powerSupplier)
        {
            _fan = fan;
            _powerSupplier = powerSupplier;
        }


        public override void Press()
        {
            if (_fan.IsOn()) {
                _fan.TurnOff();
                Stop();
            } else {
                _fan.TurnOn();
                Start();
            }
        }

        public override void Start()
        {
            _powerSupplier.TurnOn();
        }

        public override void Stop()
        {
            _powerSupplier.TurnOff();
        }
    }
}