using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "", reverse = "";

            Console.Write("Enter string: ");
            input = Console.ReadLine();

            for(int c=input.Length-1; c>=0; c--)  //reverse the string
            {
                reverse += input[c];  //build the string
            }

            string output = (input == reverse ? "Palindrome!" : "Not Palindrome!");  //compare and decide
            
            Console.WriteLine(output);

            Console.ReadLine();
        }
    }
}
