using System;

namespace Creational.AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Client();
            client.Initialize();
            var result = client.Run();

            Console.WriteLine(result);
        }
    }
}
