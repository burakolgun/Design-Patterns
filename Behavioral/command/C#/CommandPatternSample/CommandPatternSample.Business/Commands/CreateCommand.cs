using CommandPatternSample.Data.Entities;
using System.Collections.Generic;

namespace CommandPatternSample.Business.Commands
{
    public class CreateCommand : ICommand
    {
        public void Execute(List<Cart> cartList, Cart cart)
        {
            cartList.Add(cart);
        }
    }
}
