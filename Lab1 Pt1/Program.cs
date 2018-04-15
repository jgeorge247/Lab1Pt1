using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Pt1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Take user input
            Console.Write("Enter any 3 digit number: ");
            string FirstNumber = Console.ReadLine();

            Console.Write("Enter another 3 digit number: ");
            string SecondNumber = Console.ReadLine();

            //check length of input and if inputs are actually numbers
            int One, Two;
            if (FirstNumber.Length == 3 && SecondNumber.Length == 3 && int.TryParse(FirstNumber, out One) && int.TryParse(SecondNumber, out Two))
            {
                //Complete task given valid input
                Console.WriteLine(Task(FirstNumber, SecondNumber));
            }
            else
            {
                //Let user know to try again
                Console.WriteLine("Something went wrong. Try again");
            }
        }
        static bool Task(string FirstNumber, string SecondNumber)
        {
            //initialize 3 arrays with length of 3
            int[] firstarray = new int[3];
            int[] secondarray = new int[3];
            int[] thirdarray = new int[3];

            //loop through each array to convert input into numbers, and add the
            //values to the third array  
            for (int i = 0; i < 3; i++)
            {
                firstarray[i] = (int)(FirstNumber[i] - '0');
                secondarray[i] = (int)(SecondNumber[i] - '0');
                thirdarray[i] = firstarray[i] + secondarray[i];
                Console.WriteLine(firstarray[i] + " + " + secondarray[i] + " = " + thirdarray[i]);
                if (thirdarray[0] != thirdarray[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
