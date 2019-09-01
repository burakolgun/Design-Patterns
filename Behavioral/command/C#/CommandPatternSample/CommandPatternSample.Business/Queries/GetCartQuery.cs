using CommandPatternSample.Business.Commands;
using CommandPatternSample.Data.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace CommandPatternSample.Business.Queries
{
    public class GetCartQuery : IQueryCommand, IGetCartQuery
    {
        public readonly List<Cart> _cartList;
        private decimal _grandTotal = 0.0m;

        public GetCartQuery()
        {
            _cartList = new List<Cart>();
        }

        public void Display()
        {
            Console.Write("------Your Cart Info-----\n\n");
            foreach (var cart in _cartList)
            {
                var total = cart.Item.Price * cart.Quantity;
                _grandTotal += total;
                Console.Write($"Id : {cart.Id}\n");
                Console.Write($"Created Date : {cart.CreatedDate.ToString("MM/dd/yyyy HH:mm:ss.fff", CultureInfo.InvariantCulture)}\n");
                Console.Write($"Quantity : {cart.Quantity}\n");
                Console.Write($"Item Name : {cart.Item.Name}\n");
                Console.Write($"Item Price: {cart.Item.Price}\n");
                Console.Write($"Total: {total}\n\n");                
            }
            Console.Write("------Cart Total-----\n\n");
            Console.Write($"{_grandTotal}\n\n");

            _grandTotal = 0.0m;
        }

        public void Execute(ICommand command, Cart cart)
        {
            command.Execute(cartList: _cartList, cart: cart);
        }
    }
}
