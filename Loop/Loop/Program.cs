using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WHILE LOOP");
            WhileLoop();
            Console.WriteLine("DO WHILE LOOP");
            DoWhileLoop();
            Console.WriteLine("FOR LOOP");
            ForLoop();
            Console.ReadLine();
        }

        private static void WhileLoop()
        {
            short n = 0, sum = 0;
            while (n <= 10)
            {
                if ((n % 2) == 0)  //if equal to 0, even
                {
                    sum += n;  //add
                }
                n++;
            }

            Console.WriteLine("Sum is: " + sum);
        }

        private static void DoWhileLoop()
        {
            short n = 0;
            do
            {
                if ((n % 2) == 1)   //if their is remainder, odd
                {
                    Console.WriteLine(n);
                }
                n++;  
            }
            while (n <= 10);
        }

        private static void ForLoop()
        {
            // 0 1 2 3 4 5 6 7 8 9
            short sum = 0, a = 0, b = 1;

            Console.WriteLine(0);  //print the first sequence
            Console.WriteLine(1);  //print the second sequence
            for (short c = 3; c <= 10; c++)  //start from 3rd sequence 
            {
                sum = Convert.ToInt16(a + b);  //get the sum of a & b
                Console.WriteLine(sum);  //print out
                a = b;
                b = sum;
            }
        }
    }
}
