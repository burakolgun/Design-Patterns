using CommandPatternSample.Data.Entities;
using CommandPatternSample.Data.Enums;

namespace CommandPatternSample.Business
{
    public interface IInvoker
    {
        void SetCommand(CartOperationEnum cartOperationEnum);
        void Execute();
        void SetCart(Cart cart);
        void DisplayCart();

    }
}
