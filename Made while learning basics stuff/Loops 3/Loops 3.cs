using System;

namespace Loops_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numberGen = new Random();

            int roll01 = 0;
            int roll02 = 1;
            int attempts = 0;

            Console.WriteLine("Press enter to roll a die");

            while(roll01 != roll02){
                Console.ReadKey();

                roll01 = numberGen.Next(1, 7);
                roll02 = numberGen.Next(1, 7);
                
                attempts++;
                
                Console.WriteLine("Die 1 rolled: " + roll01);
                Console.WriteLine("Die 2 rolled: " + roll02 + "\n");
            }
            Console.WriteLine("It took you " + attempts + " attempts to roll two of a kind");
            
            Console.ReadKey();
        }
    }
}
