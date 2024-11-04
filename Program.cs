using System.Diagnostics;
using System.Runtime.InteropServices;

namespace CCAD16_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input your name");
            string Name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Please input your age");
            string age = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Please input your home address");
            string address = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Your name is "  + Name);
            Console.WriteLine("Your age "  + age);
            Console.WriteLine("Your address is "  + address);
            Console.WriteLine();
            Console.WriteLine($"Welcome {Name}, you are {age} years old, and your address is {address}");


        }
    }
}
