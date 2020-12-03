using System;
using Creational.Prototype.Model;

namespace Creational.Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            var address = new Address("Wroclaw", "Wroclawska", 10);
            var user = new User("Navrazz", "navrazz@example.com", address);

            var userShallow = user.ShallowCopy();
            var userDeep = user.DeepCopy();

            Console.WriteLine($"User:        {user}");
            Console.WriteLine($"UserShallow: {userShallow}");
            Console.WriteLine($"UserDeep:    {userDeep}");

            Console.WriteLine($"***************************************************************************************");

            user.ChangeUserName("Patol");
            user.ChangeUserEmail("patol@example.com");
            user.UserAddress.ChangeCity("Lowicz");
            user.UserAddress.ChangeStreet("Gnojna");
            user.UserAddress.ChangeHouseNumber(69);

            Console.WriteLine($"User:        {user}");
            Console.WriteLine($"UserShallow: {userShallow}"); //only reference value has changed
            Console.WriteLine($"UserDeep:    {userDeep}"); // nothing change
        }
    }
}
