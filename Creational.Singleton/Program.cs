using System;
using System.Threading;

namespace Creational.Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            //Single thread 

            var configOne = Config.GetInstance();
            var configTwo = Config.GetInstance();

            if (configOne == configTwo)
            {
                Console.WriteLine("Singleton works");
            }    
            else
            {
                Console.WriteLine("Singleton fails");
            }

            Console.WriteLine("****************************************************************************");

            // Multiple Thread - if you see the same value, singleton works just fine - it was reuse as intended.

            Thread processOne = new Thread(() =>
            {
                TestSingleton("processOne");
            });

            Thread processTwo = new Thread(() =>
            {
                TestSingleton("processTwo");
            });

            processOne.Start();
            processTwo.Start();

            processOne.Join();
            processTwo.Join();
        }

        static void TestSingleton(string value)
        {
            var threadSafeConfig = ThreadSafeConfig.GetInstance(value);
            Console.WriteLine(threadSafeConfig.GetPath());
        }
    }
}
