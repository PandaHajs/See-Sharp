using System;

namespace Methods_3
{
    class Program
    {
        static void Main(string[] args)
        {
            wordc();

            
            
            Console.ReadKey();
        }

        static void wordc(){

            Console.Write("Input your sentence: ");
            string sent = Convert.ToString(Console.ReadLine());
            
            int lenght = Convert.ToInt32(sent.Split(' ').Length);

            Console.WriteLine("This sentence has " + lenght + " words");
        }
    }
}
