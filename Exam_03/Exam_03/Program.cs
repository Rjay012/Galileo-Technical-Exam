using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_03
{
    class Program
    {
        static void Main(string[] args)
        {
            short number = 0;
            Console.Write("Enter a number: ");
            number = Convert.ToInt16(Console.ReadLine());

            for(short c=1; c<=number; c++)
            {
                short positiveFormula = Convert.ToInt16((5 * c * c + 4));
                short negativeFormula = Convert.ToInt16((5 * c * c - 4));
                short x = Convert.ToInt16(Math.Sqrt(positiveFormula));
                short z = Convert.ToInt16(Math.Sqrt(negativeFormula));

                //check if either one/both formula's are perfect square
                string output = ((x * x) == positiveFormula || (z * z) == negativeFormula ? c + " is fibonacci" : c + " is not fibonacci");

                Console.WriteLine(output);
            }
            Console.ReadLine();
        }
    }
}
