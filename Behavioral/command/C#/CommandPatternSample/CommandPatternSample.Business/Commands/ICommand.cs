using CommandPatternSample.Data.Entities;
using System.Collections.Generic;

namespace CommandPatternSample.Business.Commands
{
    public interface ICommand
    {
        void Execute(List<Cart> cartList, Cart cart);
    }
}
