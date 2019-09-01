using CommandPatternSample.Data.Entities;
using System.Collections.Generic;
using System.Linq;

namespace CommandPatternSample.Business.Commands
{
    public class DeleteCommand : ICommand
    {
        public void Execute(List<Cart> cartList, Cart cart)
        {
            cartList.Remove(cartList.FirstOrDefault(q => q.Id.Equals(cart.Id)));
        }
    }
}
