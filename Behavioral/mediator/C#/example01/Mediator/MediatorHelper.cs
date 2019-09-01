using example01.Component;

namespace example01.Mediator
{
    public class MediatorHelper
    {
        private static MediatorHelper _mediatorHelper;

        private readonly ConcreteMediator _powerController;

        private MediatorHelper()
        {
            _powerController =
                new ConcreteMediator(new Fan.Fan(), new PowerSupplier("power supplier"));
        }

        public static Mediator GetController()
        {
            if (_mediatorHelper == null)
            {
                _mediatorHelper = new MediatorHelper();
            }

            return _mediatorHelper._powerController;
        }
    }
}