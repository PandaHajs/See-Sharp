using System;

namespace Methods_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int result02 = Multiply(3, 3);

            Console.WriteLine("The result is " + result02);

            if(result02%2 == 0){
                Console.WriteLine("The result is an even number");
            }
            else{
                Console.WriteLine("The result is an uneven number");
            }
            
            Console.ReadKey();
        }

        static int Multiply(int num01, int num02){
            
            int result01 = num01 * num02;
            return result01;
        }
    }
}
