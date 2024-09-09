using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace MidTermProblem4
{
    internal class Program
    {
        static int Calculatefactorial(int n) //method to calculate factorial
        {
            int returnValue = 1; //declares and initalizes variable
            for (int i = 1; i <= n; i++) //for loop calculating factorial
            {
                returnValue *= i; //returnValue multiplied by i
            }
            return returnValue; //returns variable
        }
        static void Main(string[] args)
        {
            int input = 0; //declares and initalizes variable
            int sum = 0; //declares and initalizes variable
            Console.Write("Please enter a positive integer: "); //displays text asking for user input
            while (input <= 0)
            {
                input = Convert.ToInt32(Console.ReadLine()); //converts user input to variable
                if (input < 0) //if statement if user input is less than 0
                {
                    Console.Write("Please enter a positive integer: "); //displays text asking for user input if condition is met
                }
            }

            for (int i = 1; i < input; i++) //for loop to calculate the sum of the factorial
            {
                sum  += Calculatefactorial(i); //sets sum equal to method return value when inputing i
            }

            Console.WriteLine("The sum of " + input + " is: " + sum); //displays sum of factorial

            Console.Read(); //lets user read program
        }
    }
}
