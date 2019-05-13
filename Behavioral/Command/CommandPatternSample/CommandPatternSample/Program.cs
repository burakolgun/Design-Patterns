using CommandPatternSample.Business;
using CommandPatternSample.Data.Entities;
using System;

namespace CommandPatternSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("------Command Pattern Sample------\n\n");
            Invoker invoker = new Invoker();
            Cart firstCartItem = new Cart()
            {
                Id = 1,
                Item = new CartItem()
                {
                    Id = 1,
                    Name = "Test Item",
                    Price = 5
                },
                Quantity = 3
            };
            Cart secondCartItem = new Cart()
            {
                Id = 2,
                Item = new CartItem()
                {
                    Id = 2,
                    Name = "Test Item2",
                    Price = 10
                },
                Quantity = 2
            };
            Cart thirdCartItem = new Cart()
            {
                Id = 3,
                Item = new CartItem()
                {
                    Id = 3,
                    Name = "Test Item3",
                    Price = 5
                },
                Quantity = 2
            };
            invoker.SetCommand(Data.Enums.CartOperationEnum.Create);
            invoker.SetCart(firstCartItem);
            invoker.Execute();

            invoker.SetCommand(Data.Enums.CartOperationEnum.Create);
            invoker.SetCart(secondCartItem);
            invoker.Execute();

            invoker.SetCommand(Data.Enums.CartOperationEnum.Create);
            invoker.SetCart(thirdCartItem);
            invoker.Execute();

            invoker.DisplayCart();

            invoker.SetCommand(Data.Enums.CartOperationEnum.Delete);
            invoker.SetCart(thirdCartItem);
            invoker.Execute();

            invoker.DisplayCart();
            Console.Write("------Please press any button to terminate------\n");
            Console.Read();
        }
    }
}
