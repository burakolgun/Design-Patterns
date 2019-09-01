using System;

namespace connection    
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Connector connector = Connector.GetInstance();
        }
    }
}