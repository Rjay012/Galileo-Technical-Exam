using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SOLUTION A:");
            A();
            Console.WriteLine("SOLUTION B:");
            B();
            Console.WriteLine("SOLUTION C:");
            C();
            Console.ReadLine();
        }

        private static void A()
        {
            string[] arr = { "Marvin", "Marco", "Marvin", "Marco", "Marco", "Marvin", "Christian" };
            Dictionary<string, int> arrCount = new Dictionary<string, int>();
            int counter = 0;
            string value = "";
            foreach (string o in arr.Distinct())
            {
                for (short i = 0; i < arr.Length; i++)
                {
                    if (o == arr[i])  //search for duplicate values, if found get the name and start counting each duplicates
                    {
                        value = o;
                        counter++;
                    }
                }
                arrCount.Add(value, counter);
                counter = 0; //reset the counter
            }

            foreach (int o in arrCount.Values)  //loop through dictionary values
            {
                if (arrCount.Values.Max() == o)  //find the maximum value and look for duplicate value
                {
                    counter++;  //start counting duplicates
                }
            }

            if (counter > 1)  //if number of occurrences has tied, sort the array
            {
                Array.Sort(arr);  //sort the array

                foreach (string o in arr)
                {
                    Console.WriteLine(o);
                }
            }

            Console.WriteLine("Most number occurrence: " + arrCount.Values.Max());
        }

        private static void B()
        {
            short[] arr = { 9863, 7127, 2020, 80, 131, 55, 100 };

            //used bubble sort to sort array in ascending order
            for (short o = 0; o < arr.Length; o++)
            {
                for (short i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])  //if value is greater than to the next one, switch them
                    {
                        short temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                    }
                }
            }

            short val = 0;
            foreach (short c in arr)
            {
                val = (c % 2) == 1 ? (short)(Math.Round(c / 10.0) * 10) : c;  //round of if the value was odd
                Console.WriteLine(val);
            }
        }

        private static void C()
        {
            string[] arr = { "red", "blue", "black", "black", "red" }; //{ "red", "blue", "black", "red", "blue", "blue", "red", "gold" };
            List<string> arrList = new List<string>();
            foreach(string i in arr)
            {
                arrList.Add(i);
            }

            foreach(string v in arrList.ToList())
            {
                if(arrList.Where(s => s.Contains(v)).Count() > 1)   //check the array list if the index is containing value that has a number more than 1
                {
                    arrList.RemoveAll(s => s.Contains(v));  //if it does, remove all the value that is duplicated and remain those not
                }
            }

            //display
            foreach(string x in arrList)
            {
                Console.WriteLine(x);
            }
        }
    }
}
