using CommandPatternSample.Business.Commands;
using CommandPatternSample.Business.Queries;
using CommandPatternSample.Data.Entities;
using CommandPatternSample.Data.Enums;

namespace CommandPatternSample.Business
{
    public class Invoker : IInvoker
    {
        private ICommand _command;
        private Cart _cart;
        private GetCartQuery _cartQuery;
        private ICommandFactory _commandFactory;

        public Invoker()
        {
            _cartQuery = new GetCartQuery();
            _commandFactory = new CommandFactory();
        }

        public void DisplayCart()
        {
            _cartQuery.Display();
        }

        public void Execute()
        {
            _cartQuery.Execute(_command, _cart);
        }

        public void SetCart(Cart cart)
        {
            _cart = cart;
        }

        public void SetCommand(CartOperationEnum cartOperationEnum)
        {
            _command = _commandFactory.GetCommand(cartOperationEnum: cartOperationEnum);
        }
    }
}
