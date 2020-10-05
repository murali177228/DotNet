using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int marks;
            Console.Write("Enter Marks : ");
            marks = Convert.ToInt32(Console.ReadLine());
            if(marks<35)
            {
                Console.Write("Fail ");
            }
            else if(marks>=35 && marks<50)
            {
                Console.Write("Third Class ");
            }
            else if (marks >= 50 && marks < 60)
            {
                Console.Write("Second Class ");
            }
            else if (marks >= 60 && marks < 101)
            {
                Console.Write("First Class ");
            }
            else
            {
                Console.WriteLine("Please enter marks between 0 and 100");
            }



            Console.ReadKey();
        }
    }
}
