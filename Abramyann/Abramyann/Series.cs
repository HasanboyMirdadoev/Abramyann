using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abramyann
{
    class Series
    {
        public static void Series1()
        {
            int sum = 0;
            Console.WriteLine("Write 10 numbers");
            for (int i = 0; i < 10; i++)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                sum += number;
            }
            Console.WriteLine(sum);
        }
        public static void Series2()
        {
            int multiple = 1;
            Console.WriteLine("Write 10 numbers");
            for (int i = 0; i < 10; i++)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                multiple *= number;
            }
            Console.WriteLine(multiple);
        }
        public static void Series3()
        {
            int sum = 0;
            Console.WriteLine("Write 10 numbers");
            for (int i = 0; i < 10; i++)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                sum += number;
            }
            Console.WriteLine(sum / 10);
        }
        public static void Series4(int N)
        {
            int sum = 0;
            int multiple = 1;
            Console.WriteLine("Write 10 numbers");
            for (int i = 0; i < N; i++)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                sum += number;
                multiple *= number;
            }
            Console.WriteLine(sum);
            Console.WriteLine(multiple);
        }
        public static void Series5(int N)
        {
            int sum = 0;
            for (int i = 0; i < N; i++)
            {
                double double_number = Convert.ToDouble(Console.ReadLine());
                int number = Convert.ToInt32(double_number);
                Console.WriteLine($"The whole part of this number: {number}");
                sum += number;
            }
            Console.WriteLine($"The sum of whole parts: {sum}");
        }
        public static void Series6(int N)
        {
            double multiple = 1;
            for (int i = 0; i < N; i++)
            {
                double double_number = Convert.ToDouble(Console.ReadLine());
                int number = Convert.ToInt32(double_number);
                double n;
                if (number > double_number)
                {
                    n = double_number - number + 1;
                    Console.WriteLine($"Not whole part of this number: {n}");
                }
                else
                {
                    n = double_number - number;
                    Console.WriteLine($"Not whole part of this number: {n}");
                }
                multiple *= n;
            }
            Console.WriteLine($"The multiple of whole parts: {multiple}");
        }
        // Series7 ???
        public static void Series8(int N)
        {
            int k = 0;
            for (int i = 0; i < N; i++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                if (n % 2 == 0)
                {
                    Console.WriteLine($"Even number: {n}");
                    k++;
                }
            }
            Console.WriteLine($"Number of even numbers: {k}");
        }
        public static void Series9(int N)
        {
            int k = 0;
            for (int i = 0; i < N; i++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                if (n % 2 == 1)
                {
                    Console.WriteLine($"Odd number: {n}");
                    k++;
                }
            }
            Console.WriteLine($"Number of odd numbers: {k}");
        }
        public static void Sereis10(int N)
        {
            bool has_positive = false;
            for (int i = 0; i < N; i++)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                if (number >= 0)
                {
                    has_positive = true;
                    break;
                }
            }
            Console.WriteLine(has_positive);
        }
        public static void Sereis11(int N, int K)
        {
            bool has_less = false;
            for (int i = 0; i < N; i++)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                if (number < K)
                {
                    has_less = true;
                    break;
                }
            }
            Console.WriteLine(has_less);
        }
        public static void Series12()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int counter = 0;
            while (number != 0)
            {
                counter++;
                number = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"Number of numbers: {counter}");
        }
        public static void Series13()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while (number != 0)
            {
                if (number > 0 && number % 2 == 0)
                {
                    sum += number;
                }
                number = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"Number of numbers: {sum}");
        }
        public static void Series14(int K)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int counter = 0;
            while (number != 0)
            {
                if (number < K)
                    counter++;
                number = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"Number of numbers: {counter}");
        }
        public static void Series15(int K)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int counter = 1;
            while (number != 0)
            {
                if (number > K)
                {
                    Console.WriteLine(counter);
                    return;
                }
                counter++;
                number = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(0);
        }
        public static void Series16(int K)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int counter = 1;
            int lastC = 0;
            while (number != 0)
            {
                if (number > K)
                {
                    lastC = counter;
                }
                counter++;
                number = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(lastC);
        }
        // Series17 ???
        public static void Series18(int N)
        {
            int lastNumber = 0;
            for (int i = 0; i < N; i++)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                if (i == 0 || lastNumber != number)
                {
                    Console.WriteLine($"    {number}");
                }
                lastNumber = number;
            }
        }
        public static void Series19(int N)
        {
            int lastNumber = 0;
            int counter = 0;
            for (int i = 0; i < N; i++)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                if (i == 0 || lastNumber > number)
                {
                    Console.WriteLine($"    {number}");
                    counter++;
                }
                lastNumber = number;
            }
            Console.WriteLine(counter);
        }
        public static void Series20(int N)
        {
            int lastNumber = 0;
            int counter = 0;
            for (int i = 0; i < N; i++)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                if (i == N || lastNumber < number)
                {
                    Console.WriteLine($"    {lastNumber}");
                    counter++;
                }
                lastNumber = number;
            }
            Console.WriteLine(counter);
        }
        public static void Series21(int N)
        {
            int lastNumber = 0;
            bool increasing = true;
            for (int i = 0; i < N; i++)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                if (lastNumber > number && i != 0)
                {
                    increasing = false;
                    break;
                }
                lastNumber = number;
            }
            Console.WriteLine(increasing);
        }
        public static void Series22(int N)
        {
            int last_number = 0;
            for (int i = 1; i <= N; i++)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                if (number > last_number)
                {
                    Console.WriteLine(i);
                    return;
                }
                last_number = number;
            }
            Console.WriteLine(0);
        }
        public static void Series23(int N)
        {
            int last_number = 0;
            int pro_last_number = 0;
            for (int i = 0; i < N; i++)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                if (!(last_number < pro_last_number && last_number < number ||
                    last_number > pro_last_number && number < last_number) && i > 2)
                {
                    Console.WriteLine(i);
                    return;
                }
                pro_last_number = last_number;
                last_number = number;
            }
            Console.WriteLine(0);
        }
        public static void Series24(int N)
        {
            int sum = 0;
            int last_sum = 0;
            for (int i = 0; i < N; i++)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                if (number == 0)
                {
                    last_sum = sum;
                    sum = 0;
                }
                sum += number;
            }
            Console.WriteLine(last_sum);
        }
        public static void Series25(int N)
        {
            int sum = 0;
            int Sum = 0;
            int counter = 0;
            for (int i = 0; i < N; i++)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                if (number == 0)
                {
                    if (counter != 0)
                    {
                        Sum += sum;
                        sum = 0;
                    }
                    counter++;
                    sum = 0;
                }
                sum += number;
            }
            Console.WriteLine(Sum);
        }
        public static void Series26(int N, int K)
        {
            for (int i = 0; i < N; i++)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                int degree = 1;
                for (int j = 0; j < K; j++)
                {
                    degree *= number;
                }
                Console.WriteLine($"The {K} degree of {number} is {degree}");
            }
        }
        public static void Series27(int N)
        {
            for (int i = 1; i <= N; i++)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                int degree = 1;
                for (int j = 0; j < i; j++)
                {
                    degree *= number;
                }
                Console.WriteLine($"The {i} degree of {number} is {degree}");
            }
        }
        public static void Series28(int N)
        {
            for (int i = 0; i < N; i++)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                int degree = 1;
                for (int j = 0; j < N - i; j++)
                {
                    degree *= number;
                }
                Console.WriteLine($"The {N - i} degree of {number} is {degree}");
            }
        }
        public static void Series29(int N, int K)
        {
            int sum = 0;
            for (int i = 0; i < K; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    int number = Convert.ToInt32(Console.ReadLine());
                    sum += number;
                }
            }
            Console.WriteLine($"The sum is {sum}");
        }
        public static void Series30(int N, int K)
        {
            int sum = 0;
            for (int i = 0; i < K; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    int number = Convert.ToInt32(Console.ReadLine());
                    sum += number;
                }
                Console.WriteLine($"The sum is {sum}");
                sum = 0;
            }
        }
        public static void Series31(int N, int K)
        {
            int count = 0;
            for (int i = 0; i < K; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    int number = Convert.ToInt32(Console.ReadLine());
                    if (number == 2)
                    {
                        count++;
                        break;
                    }
                }
            }
            Console.WriteLine(count);
        }
        public static void Series32(int N, int K)
        {
            int count = 0;
            for (int i = 0; i < K; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    int number = Convert.ToInt32(Console.ReadLine());
                    if (number == 2)
                    {
                        count = j;
                        break;
                    }
                }
                Console.WriteLine(count);
                count = 0;
            }
        }
        public static void Series33(int N, int K)
        {
            int count = 0;
            for (int i = 0; i < K; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    int number = Convert.ToInt32(Console.ReadLine());
                    if (number == 2)
                    {
                        count = j + 1;
                    }
                }
                Console.WriteLine(count);
                count = 0;
            }
        }
        public static void Series34(int N, int K)
        {
            bool has_2 = false;
            int sum = 0;
            for (int i = 0; i < K; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    int number = Convert.ToInt32(Console.ReadLine());
                    has_2 = number == 2;
                    sum += number;
                }
                if (has_2)
                {
                    Console.WriteLine(sum);
                    has_2 = false;
                }
                else Console.WriteLine(0);
            }
        }
        public static void Series35(int K)
        {
            int counter = 0;
            for (int i = 0; i < K; i++)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                int count = 0;
                while (number != 0)
                {
                    count++;
                    number = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine(count);
                counter += count;
            }
        }
        public static void Series36(int K)
        {
            int counter = 0;
            for (int i = 0; i < K; i++)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                int lastNumber = 0;
                bool increasing = true;
                while (number != 0)
                {
                    if (number < lastNumber)
                    {
                        increasing = false;
                        break;
                    }
                    lastNumber = number;
                }
                if (increasing)
                    counter++;
            }
        }
        public static void Series37(int K)
        {
            int counter = 0;
            for (int i = 0; i < K; i++)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                int lastNumber = 0;
                bool increasing = false;
                bool unincreasing = false;
                while (number != 0)
                {
                    if (number < lastNumber && unincreasing == false)
                    {
                        unincreasing = true;
                    }
                    else if (number > lastNumber && increasing == false)
                    {
                        increasing = true;
                    }
                    lastNumber = number;
                }
                if (increasing && !unincreasing ||
                    unincreasing && !increasing)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
        public static void Series38(int K)
        {
            for (int i = 0; i < K; i++)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                int lastNumber = 0;
                bool increasing = false;
                bool unincreasing = false;
                while (number != 0)
                {
                    if (number < lastNumber && unincreasing == false)
                    {
                        unincreasing = true;
                    }
                    else if (number > lastNumber && increasing == false)
                    {
                        increasing = true;
                    }
                    lastNumber = number;
                }
                if (increasing && !unincreasing)
                {
                    Console.WriteLine(1);
                }
                else if (unincreasing && !increasing)
                {
                    Console.WriteLine(-1);
                }
                else Console.WriteLine(0);
            }
        }
        public static void Series39(int K)
        {
            int counter = 0;
            for (int i = 0; i < K; i++)
            {
                int last_number = 0;
                int pro_last_number = 0;
                int number = Convert.ToInt32(Console.ReadLine());
                bool piloo = true;
                while (number != 0)
                {
                    number = Convert.ToInt32(Console.ReadLine());
                    if (!(last_number < pro_last_number && last_number < number ||
                        last_number > pro_last_number && number < last_number) && i > 2)
                    {
                        piloo = false;
                        break; ;
                    }
                    pro_last_number = last_number;
                    last_number = number;
                }
                if (piloo)
                    counter++;
            }
            Console.WriteLine(counter);
        }
        public static void Series40(int K)
        {
            for (int i = 0; i < K; i++)
            {
                int last_number = 0;
                int pro_last_number = 0;
                int number = Convert.ToInt32(Console.ReadLine());
                bool piloo = true;
                int counter = 1;
                while (number != 0)
                {
                    number = Convert.ToInt32(Console.ReadLine());
                    if (!(last_number < pro_last_number && last_number < number ||
                        last_number > pro_last_number && number < last_number) && i > 2)
                    {
                        piloo = false;
                        break; ;
                    }
                    pro_last_number = last_number;
                    last_number = number;
                    counter++;
                }
                if (piloo)
                    Console.WriteLine(counter);
                else Console.WriteLine(last_number);
            }
        }
    }
}
