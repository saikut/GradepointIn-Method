using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradepointIn_Method
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("please enter Marks :");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(CalculateGrade(number));
            Console.ReadLine();
        }

        private static string CalculateGrade(int number)
        {
            if (number >= 80 && number <= 100)
            {
                return "Grade A+";
            }
            else if (number >= 70 && number <= 79)
            {
                return "Grade A";
            }

            else if (number >= 60 && number <= 69)
            {
                return "Grade A-";
            }
            else if (number >= 50 && number <= 59)
            {
                return "Grade B+";
            }
            else if (number >= 40 && number <= 49)
            {
                return "Grade B";
            }
            else if (number >= 0 && number <= 39)
            {
                return " Grade is : F";
               
            }
            else
            {
                return "Please enter valid Marks";

            }
        }
    }
}