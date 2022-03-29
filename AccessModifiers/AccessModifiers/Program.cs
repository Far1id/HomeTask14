using System;

namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Username daxil edin : ");
            string username = Console.ReadLine();          
            Console.WriteLine("Passwordu daxil edin");
            string password = Console.ReadLine();
            User user = new User(username)
            {
                Password = password,
            };

            user.GetInfo();
            string check = "Salam123";
            Console.WriteLine(user.HasLower(check));
            Console.WriteLine(user.HasUpper(check));
            Console.WriteLine(user.HasDigit(check));
        }
    }
}
