using System;

namespace Loops_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numberGen = new Random();
            
            int roll = 0;
            int attempts = 0;
            int number;

            Console.Write("At what number do you want to stop (between 1 and 6): ");
            number = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Press enter to roll the die");

            while(roll != number){
                Console.ReadKey();
                
                roll = numberGen.Next(1, 7);
                Console.WriteLine("You rolled: " + roll);
                attempts++;
            }
            Console.WriteLine("It took you " + attempts + " attempts to roll " + number);
            
            
            Console.ReadKey();
        }
    }
}
