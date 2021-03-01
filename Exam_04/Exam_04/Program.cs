using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_04
{
    class Program
    {
        static void Main(string[] args)
        {
            string date1 = "2019-05-31", date2 = "2018-04-05";

            Console.Write("Enter date1: ");
            date1 = Console.ReadLine();
            Console.Write("Enter date2: ");
            date2 = Console.ReadLine();

            string[] dateArr1 = date1.Split('-');
            string[] dateArr2 = date2.Split('-');

            int year = Math.Abs(Convert.ToInt32(dateArr1[0]) - Convert.ToInt32(dateArr2[0]));
            int month = Math.Abs(Convert.ToInt32(dateArr1[1]) - Convert.ToInt32(dateArr2[1]));
            int day = Math.Abs(Convert.ToInt32(dateArr1[2]) - Convert.ToInt32(dateArr2[2]));

            string output = (year > 1) ? year + " years, " : year + " year, ";
            output += (month > 1) ? month + " months, " : month + " month, ";
            output += (day > 1) ? day + " days" : day + " day";

            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
