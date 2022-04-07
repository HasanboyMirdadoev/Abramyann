using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abramyann
{
    class MinMax
    {
        public static void MinMax1(int N)
        {

            int min = Convert.ToInt32(Console.ReadLine());
            int max = min;
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Enter the number");
                int number = Convert.ToInt32(Console.ReadLine());
                if (min > number)
                    min = number;
                if (max < number)
                    max = number;
            }
            Console.WriteLine($"Minimum: {min}");
            Console.WriteLine($"Maximum: {max}");
        }
        public static void MinMax2(int N)
        {
            int minA = 0;
            int minB = 0;
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Enter the A");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the B");
                int b = Convert.ToInt32(Console.ReadLine());
                if (minA > a)
                    minA = a;
                if (minB > b)
                    minB = b;
            }
            Console.WriteLine($"The least space is {minA * minB}");
        }
        public static void MinMax3(int N)
        {
            int maxA = 0;
            int maxB = 0;
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Enter the A");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the B");
                int b = Convert.ToInt32(Console.ReadLine());
                if (maxA < a)
                    maxA = a;
                if (maxB < b)
                    maxB = b;
            }
            Console.WriteLine($"The least space is {maxA * maxB}");
        }
        public static void MinMax4(int N)
        {
            int min = 0;
            int index = 0;
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Enter the number");
                int number = Convert.ToInt32(Console.ReadLine());
                if (min > number)
                {
                    min = number;
                    index = i + 1;
                }
            }
            Console.WriteLine(index);
        }
        public static void MinMax5(int N)
        {
            double P = 0;
            int index = 0;
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Enter the m");
                int m = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the v");
                int v = Convert.ToInt32(Console.ReadLine());
                if (P < m / v)
                {
                    P = m / v;
                    index = i + 1;
                }
            }
            Console.WriteLine(index);
        }
        public static void MinMax6(int N)
        {
            Console.WriteLine("Enter the first number");
            int min = Convert.ToInt32(Console.ReadLine());
            int max = min;
            int min_index = 0;
            int max_index = 0;
            bool min_index_found = false;
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Enter the number");
                int number = Convert.ToInt32(Console.ReadLine());
                if (min > number && min_index_found == false)
                {
                    min_index = i + 1;
                    min_index_found = true;
                }
                if (max < number)
                {
                    max = number;
                    max_index = i + 1;
                }
            }
            Console.WriteLine(min_index);
            Console.WriteLine(max_index);
        }
        public static void MinMax7(int N)
        {
            Console.WriteLine("Enter the first number");
            int min = Convert.ToInt32(Console.ReadLine());
            int max = min;
            int min_index = 0;
            int max_index = 0;
            bool max_index_found = false;
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Enter the number");
                int number = Convert.ToInt32(Console.ReadLine());
                if (max < number && max_index_found == false)
                {
                    min_index = i + 1;
                    max_index_found = true;
                }
                if (min < number)
                {
                    min = number;
                    min_index = i + 1;
                }
            }
            Console.WriteLine(min_index);
            Console.WriteLine(max_index);
        }
        public static void MinMax8(int N)
        {
            Console.WriteLine("Enter the first number");
            int min = Convert.ToInt32(Console.ReadLine());
            int firstIndex = 0;
            int lastIndex = 0;
            bool firsIndex_found = false;
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Enter the first number");
                int number = Convert.ToInt32(Console.ReadLine());
                if (min > number && firsIndex_found == false)
                {
                    min = number;
                    firstIndex = i + 1;
                    firsIndex_found = true;
                }
                else if (min > number)
                {
                    min = number;
                    lastIndex = i + 1;
                }
            }
            Console.WriteLine(firstIndex);
            Console.WriteLine(lastIndex);
        }
        public static void MinMax9(int N)
        {
            Console.WriteLine("Enter the first number");
            int max = Convert.ToInt32(Console.ReadLine());
            int firstIndex = 0;
            int lastIndex = 0;
            bool firsIndex_found = false;
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Enter the first number");
                int number = Convert.ToInt32(Console.ReadLine());
                if (max < number && firsIndex_found == false)
                {
                    max = number;
                    firstIndex = i + 1;
                    firsIndex_found = true;
                }
                else if (max < number)
                {
                    max = number;
                    lastIndex = i + 1;
                }
            }
            Console.WriteLine(firstIndex);
            Console.WriteLine(lastIndex);
        }
        public static void MinMax10(int N)
        {
            Console.WriteLine("Enter the first number");
            int minOrMax = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Enter the number");
                int number = Convert.ToInt32(Console.ReadLine());
                if (minOrMax != number)
                {
                    Console.WriteLine(minOrMax);
                    return;
                }
            }
        }
        public static void MinMax25(int N)
        {
            Console.WriteLine("Enter the first number");
            int firstnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int secondnumber = Convert.ToInt32(Console.ReadLine());
            int firstnumber_index = 0;
            int secondnumber_index = 0;
            for (int i = 2; i < N; i++)
            {
                Console.WriteLine("Enter the number");
                int number = Convert.ToInt32(Console.ReadLine());
                if (firstnumber * secondnumber > secondnumber * number)
                {
                    firstnumber = secondnumber;
                    secondnumber = number;
                    firstnumber_index = i;
                    secondnumber_index = i + 1;
                }
            }
        }
        public static void MinMax26(int N)
        {
            int count = 0;
            int longestCount = 0;
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Enter the number");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number == 2)
                    count++;
                else if (longestCount < count)
                {
                    longestCount = count;
                    count = 0;
                }
            }
        }
        public static void MinMax27(int N)
        {
            int count = 1;
            int longest_count_index = 0;
            int longest_count = 0;
            Console.WriteLine("Enter the first number");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= N; i++)
            {
                Console.WriteLine("Enter the number");
                int n = Convert.ToInt32(Console.ReadLine());
                if (number == n)
                {
                    count++;
                }
                else
                {
                    number = n;
                    if (count > longest_count)
                    {
                        longest_count = count;
                        longest_count_index = i;
                    }
                    count = 0;
                }
            }
        }
    }
}
