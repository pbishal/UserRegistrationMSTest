using System;

namespace UserRegistrationTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Patterns patterns = new Patterns();
            Console.WriteLine("enter the first name:");
            Console.WriteLine(patterns.ValidateFirstName(Console.ReadLine()));

            Console.WriteLine("enter the last name:");
            Console.WriteLine(patterns.ValidateFirstName(Console.ReadLine()));
        }
    }
}
