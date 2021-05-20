using System;
using System.Collections.Generic;

namespace Arrays_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> students = new List<string>();

            int stu;

            Console.Write("How many students are in your class: ");
            stu = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input the names of your students: ");
            for (int i = 0; i < stu; i++)
            {
                students.Add(Console.ReadLine());
            }
            
            students.Sort();
            Console.WriteLine("Your students sorted alphabetically: ");

            for (int i = 0; i < stu; i++)
            {
                Console.WriteLine(students[i]);
            }
            
            Console.ReadKey();
        }
    }
}
