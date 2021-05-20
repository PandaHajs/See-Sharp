using System;

namespace Conditions_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            int height;

            Console.Write("Please input your age: ");
            age = Convert.ToInt32( Console.ReadLine() );

            Console.Write("Please input your height (in centimeters): ");
            height = Convert.ToInt32( Console.ReadLine() );

            if( age >= 18 && height >= 160){
                Console.WriteLine("You can enter!");
            }
            else if(age >= 18 && height <= 160){
                Console.WriteLine("Come back when you're taller, sorry!");
            }
            else if( age <= 18 && height >= 160 ){
                int diff = 18 - age;
                Console.WriteLine("Come back in " + diff +  " years kiddo");
            }
            else{
                Console.WriteLine("You gotta grow up first");
            }
            
            
            Console.ReadKey();
        }
    }
}
