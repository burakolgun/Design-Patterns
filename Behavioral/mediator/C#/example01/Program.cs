using System;
using example01.Button;

namespace example01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            //client
            IButton button = new Button.Button();
            
            button.Press();
            button.Press();
            button.Press();
            button.Press();
            button.Press();
            
        }
    }
}
