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
        static double check(){
           var num = Console.ReadLine();
           double.TryParse(num, out double ans);
           return ans;
        }
        static void add(){
            Console.WriteLine("How many numbers do you want to add to each other: ");
            var chk = check();
                    if(chk != 0){
            
            double num02 = Convert.ToDouble(chk);
            if(num02 > 0){
            double result = 0;
            num02++;
            
            for (int i = 1; i < num02; i++)
            {
                Console.WriteLine("Type in your " + i + " number");
                var chk02 = check();
                if(chk02 !=0){
                double numTyped02 = Convert.ToDouble(chk02);
                result = result + numTyped02;
                }else{
                    Console.WriteLine("Please input a valid number");
                }}
            Console.WriteLine("The numbers sum up to: " + result);
                }else{
                    Console.WriteLine("That's not a valid option");
                }
        }else{
                    Console.WriteLine("Please input a valid number");
                }
        }
        
        static void sub(){
            Console.WriteLine("How many numbers do you want to subtract from: ");
            Console.WriteLine("THE FIRST NUMBER IS THE ONE YOU WANT TO SUBSTRACT NEXT NUMBERS FROM");
            var chk = check();
            if(chk == 0 ){
                Console.WriteLine("Please input a valid number");
            }else{
            double num02 = Convert.ToDouble(chk);
            if(num02 > 0){
            double result = 0;
            num02++;
            
            for (int i = 1; i < num02; i++)
            {
                Console.WriteLine("Type in your " + i + " number");
                var numTyped = check();
                if(numTyped == 0){
                    Console.WriteLine("Please input a valid number");
                }else{
                double numTyped02 = Convert.ToDouble(numTyped);
                if(i==1){
                    result = numTyped02;
                }
                else{
                    result = result - numTyped02;
                }
                }
            }
            Console.WriteLine("The number after substraction is: " + result);
            }else{
                Console.WriteLine("That's not a valid option");
                            }
            }
        }
        
        static void mult(){
            Console.WriteLine("How many numbers do you want to multiply with each other: ");
            var num = check();
            if(num == 0){
                Console.WriteLine("Please input a valid number");
            }else{
            double num02 = Convert.ToDouble(num);
            if(num02 > 0){
            double result = 1;
            num02++;
            
            for (int i = 1; i < num02; i++)
            {
                Console.WriteLine("Type in your " + i + " number");
                double numTyped = check();
                if(numTyped != 0){
                    double numTyped02 = Convert.ToDouble(numTyped);
                    result = result * numTyped;
                }else{
                Console.WriteLine("Please input a valid number");
                }
            }
            Console.WriteLine("The numbers multiply up to: " + result);
            }
            else{
                Console.WriteLine("That's not a valid option");
            }
            }
        }

        static void div(){
            Console.WriteLine("How many numbers do you want to divide with each other: ");
            var num = check();
            if(num == 0){
                Console.WriteLine("Please input a valid number");
            }else{
            double num02 = Convert.ToDouble(num);
            if(num02 > 0){
            double res;
            Console.WriteLine("Type in your 1 number");
            res = check();
            if(res == 0){
                Console.WriteLine("Please input a valid number");
            }else{
            double result = Convert.ToDouble(res);
            double numTyped02 = 0;
            for (int i = 1; i < num02; i++){
                Console.WriteLine("Type in your " + (i+1) + " number");
                var numTyped = check();
                if(numTyped == 0){
                    Console.WriteLine("Please input a valid number");
                    break;
                }else{
                double numTyped03 = numTyped02;
                numTyped02 = Convert.ToDouble(numTyped);
                if(numTyped02 != 0){
                result = result / numTyped02;
                }
                else{
                    Console.WriteLine("You can't divide by 0!");
                    break;
                }
                }
            }
            if(numTyped02 != 0){
            Console.WriteLine("The number after division is: " + result);}
            }
            }else{
                Console.WriteLine("That's not a valid option");}}
            }

        static void exp(){
            Console.WriteLine("What number do you want to exponentiate");
            var num = check();
            if(num == 0){
                Console.WriteLine("Please input a valid number");
            }else{
            double num02 = Convert.ToDouble(num);

            Console.WriteLine("To what power do you want to exponentiate");
            var power = check();
            if(power == 0){
                Console.WriteLine("Please input a valid number");
            }else{
            int power02 = Convert.ToInt32(power);

            double result = Math.Pow(num02, power02);

            Console.WriteLine(num + " raised to the power of " + power + " is " + result);
            }
            }
        }

        static void root(){
            Console.WriteLine("What number do you want to root: ");
            var num = check();
            if(num == 0){
                Console.WriteLine("Please input a valid number");
            }else{
            double num02 = Convert.ToDouble(num);

            Console.WriteLine("What degree should the root be: ");
            var power = check();
            if(power == 0){
                Console.WriteLine("Please input a valid number");
            }else{
            double power02 = Convert.ToInt32(power);
            double result = Math.Pow(num02, (1/power02));

            Console.WriteLine(num + " rooted to the degree of " + power + " is " + result);
            }
            }
        }
    }
}
