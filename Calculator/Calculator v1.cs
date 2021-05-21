using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 1;)
            {
            Console.WriteLine("What kind of calculation do you want to do: ");
            Console.WriteLine("Addition(+), Subtraction(-), Multiplication(*), Division(/), Exponentiation(^) or Rooting(v)");
            Console.WriteLine("You can also exit by typing 'exit' or by pressing enter");

            string cal01 = Convert.ToString(Console.ReadLine());

            switch(cal01){

                case "addition" or "+":
                    add();
                    break;

                case "subtraciton" or "-":
                    sub();
                    break;

                case "multiplication" or "*":
                    mult();
                    break;

                case "divison" or "/":
                    div();
                    break;

                case "exponentiation" or "^":
                    exp();
                    break;

                case "rooting" or "v":
                    root();
                    break;

                case "exit" or "":
                    i++;
                    break;
                default:
                    Console.WriteLine("That's not a possible command");
                    break;
            }
            }
        }
        static void add(){
            Console.WriteLine("How many numbers do you want to add to each other: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if(num > 0){
            double result = 0;
            num++;

            for (int i = 1; i < num; i++)
            {
                Console.WriteLine("Type in your " + i + " number");
                double numTyped = Convert.ToDouble(Console.ReadLine());
                result = result + numTyped;
            }
            Console.WriteLine("The numbers sum up to: " + result);
            }
            else{
                Console.WriteLine("That's not a valid option");
            }
        }

        static void sub(){
            Console.WriteLine("How many numbers do you want to subtract from: ");
            Console.WriteLine("THE FIRST NUMBER IS THE ONE YOU WANT TO SUBSTRACT NEXT NUMBERS FROM");
            int num = Convert.ToInt32(Console.ReadLine());
            if(num > 0){
            double result = 0;
            num++;

            for (int i = 1; i < num; i++)
            {
                Console.WriteLine("Type in your " + i + " number");
                double numTyped = Convert.ToDouble(Console.ReadLine());
                if(i==1){
                    result = numTyped;
                }
                else{
                    result = result - numTyped;
                }
            }
            Console.WriteLine("The number after substraction is: " + result);
            }
            else{
                Console.WriteLine("That's not a valid option");
            }
        }

        static void mult(){
            Console.WriteLine("How many numbers do you want to multiply with each other: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if(num > 0){
            double result = 1;
            num++;

            for (int i = 1; i < num; i++)
            {
                Console.WriteLine("Type in your " + i + " number");
                double numTyped = Convert.ToDouble(Console.ReadLine());
                result = result * numTyped;
            }
            Console.WriteLine("The numbers multiply up to: " + result);
            }
            else{
                Console.WriteLine("That's not a valid option");
            }
        }

        static void div(){
            Console.WriteLine("How many numbers do you want to divide with each other: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if(num > 0){
            double result = 1;
            num++;
            double numTyped = 0;

            for (int i = 1; i < num; i++)
            {
                Console.WriteLine("Type in your " + i + " number");
                numTyped = Convert.ToDouble(Console.ReadLine());
                if(numTyped != 0){
                result = result / numTyped;
                }
                else{
                    Console.WriteLine("You can't divide by 0!");
                    break;
                }
            }
            if(numTyped != 0){
            Console.WriteLine("The number after division is: " + result);}
            }
            else{
                Console.WriteLine("That's not a valid option");
            }
        }

        static void exp(){
            Console.WriteLine("What number do you want to exponentiate");
            double num = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("To what power do you want to exponentiate");
            int power = Convert.ToInt32(Console.ReadLine());

            double result = Math.Pow(num, power);

            Console.WriteLine(num + " raised to the power of " + power + " is " + result);
        }

        static void root(){
            Console.Write("What number do you want to root: ");
            double num = Convert.ToDouble(Console.ReadLine());

            Console.Write("What degree should the root be: ");
            double power = Convert.ToInt32(Console.ReadLine());

            double result = Math.Pow(num, (1/power));

            Console.WriteLine(num + " rooted to the degree of " + power + " is " + result);

        }
    }
}