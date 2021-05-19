using System;

namespace Variables_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            string userName = Console.ReadLine();

            Console.WriteLine("Hello " + userName + ", nice to meet you!");

            Console.ReadKey();
        }
    }
}
