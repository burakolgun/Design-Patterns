using System;
using Player;
using Player.Factory;

namespace factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IPlayerFactory playerFactory = new PlayerFactory();

            IPlayer player = playerFactory.GetPlayer(Player.Enum.Type.Newbie);
            IPlayer player2 = playerFactory.GetPlayer(Player.Enum.Type.ProPlayer);
        }
    }
}