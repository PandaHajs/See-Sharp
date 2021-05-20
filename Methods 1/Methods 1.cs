using System;

namespace Methods_1
{
    class Program
    {
        static void Main(string[] args){
           int meet;

            Console.Write("How many xenos you want to meet: ");
            meet = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < meet; i++)
            {
                MeetAlien();
                Console.WriteLine("-------------");
                Console.ReadKey();
            }
        }

        static void MeetAlien(){
            Random numberGen = new Random();

            string name = "X-" + numberGen.Next(10, 9999);
            int age = numberGen.Next(18, 500);

            Console.WriteLine("Hi! I'm " + name);
            Console.WriteLine("I'm " + age + " years old");
            Console.WriteLine("Oh, and I'm an xeno.");
        }
    }
}
