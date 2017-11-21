using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarations
            
            
            
            

            // Initilizations
            string Name;
            Console.Write("Enter Name:  ");
            Name = Console.ReadLine();

            int Age;
            Console.Write("How old are you?:  ");
            Age = int.Parse(Console.ReadLine());
            if (Age >= 21)
            {
                Console.Write("What is your pin number?");
                //todo: finish this up.
            }

            string SSN;
            Console.Write("What is your ssn?:  ");
            SSN = Console.ReadLine();

            // Logic
            Console.WriteLine("Hello {0}! You are {1}. Have a great day.", Name, Age);
            Console.ReadKey();
            Console.WriteLine("I promise not to use {0}", SSN);
            Console.ReadKey();
            Console.WriteLine(";)");
            Console.ReadKey();
            

            


            
        }
    }
}
