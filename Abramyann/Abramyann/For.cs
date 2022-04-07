using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abramyann
{
    class For
    {
        public static void For1(int k, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(k);
            }
        }
        public static void For2(int a, int b)
        {
            for (int i = b; i >= a; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(b - a + 1);
        }
        public static void For3(int a, int b)
        {
            for (int i = b - 1; i > a; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(b - a + 1);
        }
        public static void For4(int a)
        {
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine($"{i} kg chocolate costs {i * a}$");
            }
        }
        public static void For5(int a)
        {
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine($"{i / 10} kg chocolate costs {(i / 10) * a}$");
            }
        }
        public static void For6(int a)
        {
            for (int i = 12; i < 20; i++)
            {
                Console.WriteLine($"{i / 10} kg chocolate costs {(i / 10) * a}$");
            }
        }
        public static void For7(int a, int b)
        {
            int sum = 0;
            for (int i = a; i <= b; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }
        public static void For8(int a, int b)
        {
            int multiple = 0;
            for (int i = a; i <= b; i++)
            {
                multiple *= i;
            }
            Console.WriteLine(multiple);
        }
        public static void For9(int a, int b)
        {
            int sum = 0;
            for (int i = a; i <= b; i++)
            {
                sum += i * i;
            }
            Console.WriteLine(sum);
        }
        public static void For10(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += 1 / i;
            }
            Console.WriteLine(sum);
        }
        public static void For11(int n)
        {
            int sum = 0;
            for (int i = n; i <= 2 * n; i++)
            {
                sum += i * i;
            }
            Console.WriteLine(sum);
        }
        public static void For12(int n)
        {
            double multy = 1;
            for (int i = 1; i <= n; i++)
            {
                multy *= 1 + i / 10;
            }
            Console.WriteLine(multy);
        }
        public static void For13(int n)
        {
            double sum = 1;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0) sum -= i / 10;
                else sum += i / 10;
            }
            Console.WriteLine(sum);
        }
        public static void For14(int n)
        {
            int n2 = 0;
            for (int i = 1; i < 2 * n + 1; i += 2)
            {
                n2 += i;
                Console.WriteLine(n2);
            }
        }
        public static void For15(int a, int n)
        {
            int degree = 1;
            for (int i = 0; i < n; i++)
            {
                degree *= a;
            }
            Console.WriteLine(degree);
        }
        public static void For16(int a, int n)
        {
            int degree = 1;
            for (int i = 0; i < n; i++)
            {
                degree *= a;
                Console.WriteLine(degree);
            }
        }
        public static void For17(int a, int n)
        {
            int degree = 1;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += degree;
                degree *= a;
            }
            Console.WriteLine(sum);
        }
        public static void For18(int a, int n)
        {
            int degree = 1;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0) sum += degree;
                else sum -= degree;
                degree *= a;
            }
            Console.WriteLine(sum);
        }
        public static void For19(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            Console.WriteLine(fact);
        }
        public static void For20(int n)
        {
            int sum = 0;
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
                sum += fact;
            }
            Console.WriteLine(sum);
        }
        public static void For21(int n)
        {
            int sum = 0;
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
                sum += 1 / fact;
            }
            Console.WriteLine(sum);
        }
        public static void For22(int x, int n)
        {
            int fact = 1;
            int degrees = 1;
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += degrees / fact;
                fact *= i;
                degrees *= x;
            }
            Console.WriteLine(sum);
        }
        public static void For23(int x, int n)
        {
            int negapos = 1;
            int fact = 1;
            int degrees = x;
            int sum = 0;
            for (int i = 3; i < 2 * n + 1; i += 2)
            {
                sum += negapos * degrees / fact;
                degrees *= x * x;
                fact *= i * (i - 1);
                negapos *= -1;
            }
            Console.WriteLine(sum);
        }
        public static void For24(int x, int n)
        {
            int negapos = 1;
            int fact = 1;
            int degrees = 1;
            int sum = 0;
            for (int i = 2; i < 2 * n; i += 2)
            {
                sum += negapos * degrees / fact;
                degrees *= x * x;
                fact *= i * (i - 1);
                negapos *= -1;
            }
        }
        public static void For25(int x, int n)
        {
            int sum = 0;
            int degrees = 1;
            int negspos = 1;
            for (int i = 1; i < n; i++)
            {
                degrees *= x;
                sum += negspos * degrees / i;
                negspos *= -1;
            }
            Console.WriteLine(sum);
        }
        public static void For26(int x, int n)
        {
            int sum = 0;
            int degrees = x;
            int negspos = 1;
            for (int i = 1; i < 2 * n + 1; i += 2)
            {
                sum += negspos * degrees / i;
                degrees *= x * x;
                negspos *= -1;
            }
            Console.WriteLine(sum);
        }
        public static void For27(int x, int n)
        {
            int sum = 0;
            int degrees = x;
            int oddMulty = 1;
            int evenMulty = 1;
            for (int i = 1; i < 2 * n + 1; i += 2)
            {
                oddMulty *= i;
                if (i > 1) evenMulty /= i - 2;
                evenMulty *= (i - 1) * i;
                sum += oddMulty * degrees / evenMulty;
                degrees *= x * x;
            }
            Console.WriteLine(sum);
        }
        public static void For28(int x, int n)
        {
            int sum = 0;
            int oddMulty = 1;
            int evenMulty = 1;
            int negapos = 1;
            int degrees = 1;
            for (int i = 2; i <= 2 * n; i += 2)
            {
                sum += negapos * oddMulty * degrees / evenMulty;
                degrees *= x;
                if (i > 2) oddMulty *= i - 3;
                evenMulty *= i;
                negapos *= -1;
            }
            Console.WriteLine(sum);
        }
        public static void For29(int n, int a, int b)
        {
            int l = b - a;
            double h = l / n;
            Console.WriteLine(h);
            for (int i = 0; i < n; i++)
            {
                double point = a + i * h;
                Console.WriteLine(point);
            }
        }
        public static void For31(int n)
        {
            double Ak = 2;
            for (int i = 1; i < n; i++)
            {
                double new_Ak = 2 + 1 / Ak;
                Ak = new_Ak;
                Console.WriteLine(new_Ak);
            }
        }
        public static void For33(int n)
        {
            int F1 = 1;
            int F2 = 2;
            for (int i = 3; i < n; i++)
            {
                int new_F = F1 + F2;
                F1 = F2;
                F2 = new_F;
                Console.WriteLine(new_F);
            }
        }
        public static void For35(int n)
        {
            int A1 = 1;
            int A2 = 2;
            int A3 = 3;
            for (int i = 4; i < n; i++)
            {
                int new_A = A3 + A2 - 2 * A1;
                A1 = A2;
                A2 = A3;
                A3 = new_A;
                Console.WriteLine(new_A);
            }
        }
        public static void For36(int n, int k)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                int number = i;
                for (int j = 1; j < k; j++)
                {
                    number *= i;
                }
                sum += number;
            }
            Console.WriteLine(sum);
        }
        public static void For37(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                int number = i;
                for (int j = 1; j < i; j++)
                {
                    number *= i;
                }
                sum += number;
            }
            Console.WriteLine(sum);
        }
        public static void For38(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                int number = i;
                for (int j = 0; j <= n - i; j++)
                {
                    number *= i;
                }
                sum += number;
            }
            Console.WriteLine(sum);
        }
        public static void For39(int a, int b)
        {
            for (int i = a; i <= b; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
        public static void For40(int a, int b)
        {
            int counter = 1;
            for (int i = a; i <= b; i++)
            {
                for (int j = 0; j < counter; j++)
                {
                    Console.Write(i);
                }
                counter++;
                Console.WriteLine();
            }
        }
    }
}
