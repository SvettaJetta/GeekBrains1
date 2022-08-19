using System;
using System.IO;

namespace Example
{
    class Program
    {
        public static int task01(int a, int b)
        {
            int max = 0;

            if (a > b)
                max = a;
            else
                max = b;

            return max;
        }
        public static int task02(int[] list)
        {
            int max = list[0];
            foreach (int x in list)
            {
                if (x > max)
                    max = x;

            }
       

            return max;
        }
        public static String task03(int n)
        {
            String text = "no";

            if((n%2) == 0)
            {
                text = "yes";
            }
            return text;
        }
        public static void task04(int n)
        {
            String result = "even numbers:";
            for (int i = 1; i <= n;)
            {
                if ((i % 2) == 0)
                {
                    result += "  " + Convert.ToString(i);
                    
                }

                i++;

            }
            Console.WriteLine(result);
        }        
        static void Main(string[] args)
        {      

            Console.WriteLine("Hello World!");

            Console.WriteLine("task01");
            Console.WriteLine("Enter two numbers ");        
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());      
            Console.WriteLine("max number: " + task01(a, b));

            Console.WriteLine("task02");
            Console.WriteLine("Enter numbers ");
            int number01 = Convert.ToInt32(Console.ReadLine());
            int number02 = Convert.ToInt32(Console.ReadLine());
            int number03 = Convert.ToInt32(Console.ReadLine());
            int[] numbers = { number01, number02, number03 };
            Console.WriteLine("max number: " + task02(numbers));

            Console.WriteLine("task03");
            Console.WriteLine("Enter value to define even number");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("even number - " + task03(n));

            Console.WriteLine("task04");
            Console.WriteLine("Enter value to get all even numbers");
            int nn = Convert.ToInt32(Console.ReadLine());
            task04(nn);


        }
    }
}
