using System;

namespace Conditions_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int ans01 = 24;
            int uans01;
           
            int ans02 = 84;
            int uans02;
           
            int ans03 = 7;
            int uans03;

            int correct = 0;
            int wrong = 0;

            Console.Write("18 + 6 = ");
            uans01 = Convert.ToInt32( Console.ReadLine() );
            if( ans01 == uans01){
                Console.WriteLine("Correct!");
                correct += 1;
            }
            else{
                Console.WriteLine("Wrong!");
                wrong += 1;
            }

            Console.Write("42 * 2 = ");
            uans02 = Convert.ToInt32( Console.ReadLine() );
            if( ans02 == uans02){
                Console.WriteLine("Correct!");
                correct += 1;
            }
            else{
                Console.WriteLine("Wrong!");
                wrong += 1;
            }

            Console.Write("(2*5+4) / 2 = ");
            uans03 = Convert.ToInt32( Console.ReadLine() );
            if( ans03 == uans03){
                Console.WriteLine("Correct!");
                correct += 1;
            }
            else{
                Console.WriteLine("Wrong!");
                wrong += 1;
            }

            if( correct >= 2){
                Console.WriteLine("Congratulations! You pass!");
            }
            else{
                Console.WriteLine("Congratulations! You made " + wrong + " mistakes, you fucking idiot!");
            }

            Console.ReadKey();
        }
    }
}
