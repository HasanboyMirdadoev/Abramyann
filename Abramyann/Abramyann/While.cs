using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abramyann
{
    class While
    {
        public static void While1(int A, int B)
        {
            int _B = 0;
            while (A - _B >= B)
            {
                _B += B;
            }
            Console.WriteLine(A - _B);
        }
        public static void While2(int A, int B)
        {
            int counter = 0;
            int _B = 0;
            while (A - _B >= B)
            {
                _B += B;
                counter++;
            }
            Console.WriteLine(counter);
        }
        public static void While3(int N, int K)
        {
            int counter = 0;
            int rem = 0;
            int k = 0;
            while (N - k >= K)
            {
                k += K;
                counter++;
            }
            rem = N - k;
            Console.WriteLine(counter);
            Console.WriteLine(rem);
        }
        public static void While4(int N)
        {
            int degree = 1;
            while (degree < N)
            {
                degree *= 3;
            }
            if (degree == N) Console.WriteLine("true");
            else Console.WriteLine("false");
        }
        public static void While5(int N)
        {
            int counter = 0;
            int deg = 1;
            while (deg < N)
            {
                deg *= 2;
                counter++;
            }
            Console.WriteLine(counter);
        }
        public static void While6(int N)
        {
            int k = 0;
            int fact = 1;
            while (!(N - k < 2))
            {
                fact *= N - k;
                k += 2;
            }
            Console.WriteLine(fact);
        }
        public static void While7(int N)
        {
            int K = 1;
            while (!(K * K > N))
            {
                K += 1;
            }
            Console.WriteLine(K);
        }
        public static void While8(int N)
        {
            int k = 1;
            while (!(k * k > N))
            {
                k += 1;
            }
            Console.WriteLine(k - 1);
        }
        public static void While9(int N)
        {
            int k = 0;
            int degree = 1;
            while (!(degree > N))
            {
                degree *= 3;
                k += 1;
            }
            Console.WriteLine(k);
        }
        public static void While10(int N)
        {
            int k = 0;
            int degree = 1;
            while (degree < N)
            {
                degree *= 3;
                k += 1;
            }
            Console.WriteLine(k - 1);
        }
        public static void While11(int N)
        {
            int k = 1;
            while ((k * (k + 1)) / 2 < N)
            {
                k += 1;
            }
            Console.WriteLine(k);
        }
        public static void While12(int N)
        {
            int k = 1;
            while ((k * (k + 1)) / 2 < N)
            {
                k += 1;
            }
            Console.WriteLine(k - 1);
        }
        public static void While13(int N)
        {
            int k = 1;
            double sum = 0;
            while (sum < N)
            {
                sum += 1 / k;
                k += 1;
            }
            Console.WriteLine(k);
            Console.WriteLine(sum);
        }
        public static void While14(int N)
        {
            int k = 1;
            double sum = 0;
            while (sum < N)
            {
                sum += 1 / k;
                k += 1;
            }
            Console.WriteLine(k - 1);
            Console.WriteLine(sum - 1 / k);
        }
        public static void While15(int P)
        {
            double sum = 1000;
            int k = 0;
            double interest = 1000;
            while (sum < 2100)
            {
                interest += (P * interest) / 100;
                sum += interest;
                k += 1;
            }
            Console.WriteLine(k);
            Console.WriteLine(sum);
        }
        public static void While16(int P)
        {
            int k = 1;
            double sum = 10;
            double interest = 10;
            while (sum < 200)
            {
                interest += (interest * P) / 100;
                sum += interest;
                k += 1;
            }
            Console.WriteLine(k);
            Console.WriteLine(sum);
        }
        public static void While17(int N)
        {
            int number = 0;
            int k = 10;
            int sum = 0;
            while (sum != N)
            {
                number = N % k;
                number = number / (k / 10);
                sum += number * k / 10;
                k *= 10;
                Console.Write(number);
            }
        }
        public static void While18(int N)
        {
            int k = 10;
            int number = 0;
            int sum = 0;
            int counter = 0;
            while (number != N)
            {
                int n = N % k;
                n = n / (k / 10);
                number += n * (k / 10);
                sum += n;
                k *= 10;
                counter++;
            }
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Numbers: {counter}");
        }
        public static void While19(int N)
        {
            int number = 0;
            int k = 10;
            int sum = 0;
            while (sum != N)
            {
                number = N % k;
                number = number / (k / 10);
                sum += number * k / 10;
                k *= 10;
                Console.Write(number);
            }
        }
        public static void While20(int N)
        {
            int k = 10;
            int number = 0;
            int sum = 0;
            bool has2 = false;
            while (sum != N)
            {
                number = N % k;
                number = number / (k / 10);
                sum += number * k / 10;
                if (has2 = number == 2) break;
                k *= 10;
            }
            Console.WriteLine(has2);
        }
        public static void While21(int N)
        {
            int k = 10;
            int number = 0;
            int sum = 0;
            bool has2 = false;
            while (sum != N)
            {
                number = N % k;
                number = number / (k / 10);
                sum += number * k / 10;
                if (has2 = number % 2 == 1) break;
                k *= 10;
            }
            Console.WriteLine(has2);
        }
        public static void While22(int N)
        {
            int k = 2;
            bool a = false;
            while (Math.Sqrt(N) >= k)
            {
                if (a = N % k == 0) break;
                k++;
            }
            Console.WriteLine(!a);
        }
        public static void While23(int A, int B)
        {
            int q = 1;
            int r = 1;
            while (r != 0)
            {
                q = A / B;
                r = A % B;
                A = B;
                B = r;
            }
            Console.WriteLine(A);
        }
    }
}
