using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_05
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "", reverse = "";

            Console.Write("Enter string: ");
            input = Console.ReadLine();

            for(int c=input.Length-1; c>=0; c--)  //from up to down
            {
                reverse += input[c];
            }

            Console.WriteLine(reverse);

            Console.ReadLine();
        }
    }
}
