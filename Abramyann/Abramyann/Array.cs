using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abramyann
{
    class Array_
    {
        static Random rnd = new Random();
        //Формирование массива и вывод его элементов
        public static int[] Array1(int N)
        {
            int[] array = new int[N];
            int count = 0;
            for (int i = 1; i <= 2 * N - 1; i += 2)
            {
                array[count] = i;
                count++;
            }
            return array;
        }
        public static int[] Array2(int N)
        {
            int[] array = new int[N];
            int number = 1;
            for (int i = 1; i <= N; i++)
            {
                array[i - 1] = number *= 2;
            }
            return array;
        }
        public static int[] Array3(int A, int D, int N)
        {
            int[] array = new int[N];
            int number = A;
            for (int i = 0; i < N; i++)
            {
                array[i] = number;
                number += D;
            }
            return array;
        }
        public static int[] Array4(int A, int D, int N)
        {
            int[] array = new int[N];
            int number = A;
            for (int i = 0; i < N; i++)
            {
                array[i] = number;
                number *= D;
            }
            return array;
        }
        public static int[] Array5(int N)
        {
            int[] array = new int[N];
            int F1 = 1;
            int F2 = 1;
            array[0] = 1;
            array[1] = 1;
            for (int i = 2; i < N; i++)
            {
                int F3 = F1 + F2;
                array[i] = F3;
                F1 = F2;
                F2 = F3;
            }
            return array;
        }
        public static void Array13(int[] A, int N)
        {
            for (int i = N - 1; i >= 0; i -= 2)
            {
                Console.WriteLine(A[i]);
            }
        }
        public static void Array14(int[] A, int N)
        {
            for (int i = 0; i < N; i += 2)
            {
                Console.WriteLine(A[i]);
            }
            for (int i = 1; i < N; i += 2)
            {
                Console.WriteLine(A[i]);
            }
        }
        public static void Array15(int[] A, int N)
        {
            for (int i = 1; i < N; i += 2)
            {
                Console.WriteLine(A[i]);
            }
            if (N % 2 == 1)
                for (int i = N - 1; i >= 0; i -= 2)
                {
                    Console.WriteLine(A[i]);
                }
            else
                for (int i = N - 2; i >= 0; i -= 2)
                {
                    Console.WriteLine(A[i]);
                }
        }
        public static void Array16(int[] A, int N)
        {
            for (int i = 0; i < N / 2; i++)
            {
                Console.WriteLine(A[i]);
                Console.WriteLine(A[N - 1 - i]);
            }
        }
        public static void Array17(int[] A, int N)
        {
            for (int i = 0; i < N / 2; i++)
            {
                Console.WriteLine(A[i]);
                Console.WriteLine(A[i + 1]);
                Console.WriteLine(A[N - 1 - i]);
                Console.WriteLine(N - 1 - (i + 1));
            }
        }
        //Анализ элементов массива
        public static void Array18()
        {
            int[] array = new int[10];
            for (int i = 0; i < 10; i++)
            {
                if (array[i] < array[9])
                {
                    Console.WriteLine(array[i]);
                    return;
                }
            }
            Console.WriteLine(0);
        }
        public static void Array19()
        {
            int[] array = new int[10];
            int index = 0;
            for (int i = 1; i < 10; i++)
            {
                if (array[i] > array[0] && array[i] < array[9])
                {
                    index = i;
                }
            }
            Console.WriteLine(index);
        }
        public static void Array20(int K, int L, int N)
        {
            int[] array = new int[N];
            int sum = 0;
            for (int i = K; i <= L; i++)
            {
                sum += array[i];
            }
            Console.WriteLine(sum);
        }
        public static void Array21(int K, int L, int N)
        {
            int[] array = new int[N];
            int sum = 0;
            for (int i = K; i <= L; i++)
            {
                sum += array[i];
            }
            double avarae = sum / (L - K + 1);
            Console.WriteLine(avarae);
        }
        public static void Array22(int K, int L, int N)
        {
            int[] array = new int[N];
            int sumKL = 0;
            int sum = 0;
            for (int i = 0; i < N; i++)
            {
                sum += array[i];
            }
            for (int i = K; i <= L; i++)
            {
                sumKL += array[i];
            }
            Console.WriteLine(sum - sumKL);
        }
        public static void Array23(int K, int L, int N)
        {
            int[] array = new int[N];
            int sumKL = 0;
            int sum = 0;
            for (int i = 0; i < N; i++)
            {
                sum += array[i];
            }
            for (int i = K; i <= L; i++)
            {
                sumKL += array[i];
            }
            Console.WriteLine((sum - sumKL) / (N - (L - K + 1)));
        }
        public static void Array24(int N)
        {
            int[] array = new int[N];
            int d = array[1] - array[0];
            for (int i = 2; i < N; i++)
            {
                if (array[i] - array[i - 1] != d)
                {
                    Console.WriteLine(0);
                    return;
                }
            }
            Console.WriteLine(d);
        }
        public static void Array25(int N)
        {
            int[] array = new int[N];
            int d = array[1] / array[0];
            for (int i = 2; i < N; i++)
            {
                if (array[i] / array[i - 1] != d)
                {
                    Console.WriteLine(0);
                    return;
                }
            }
            Console.WriteLine(d);
        }
        public static void Arra26(int N)
        {
            int[] array = new int[N];
            if (array[0] % 2 == 0)
            {
                for (int i = 1; i < N; i++)
                {
                    if (i % 2 != array[i] % 2)
                    {
                        Console.WriteLine(i);
                        return;
                    }
                }
            }
            else
            {
                for (int i = 1; i < N; i++)
                {
                    if (!(i % 2 == 1 && array[i] % 2 == 0 || i % 2 == 0 && array[i] % 2 == 1))
                    {
                        Console.WriteLine(i);
                        return;
                    }
                }
            }
            Console.WriteLine(0);
        }
        public static void Arra27(int N)
        {
            int[] array = new int[N];
            if (array[0] < 0)
            {
                for (int i = 1; i < N; i++)
                {
                    if (i % 2 == 1 && array[i] < 0 || i % 2 == 0 && array[i] > 0)
                    {
                        Console.WriteLine(i);
                        return;
                    }
                }
            }
            else
            {
                for (int i = 1; i < N; i++)
                {
                    if (i % 2 == 1 && array[i] > 0 || i % 2 == 0 && array[i] < 0)
                    {
                        Console.WriteLine(i);
                        return;
                    }
                }
            }
            Console.WriteLine(0);
        }
        public static void Array40(int R, int N)
        {
            int r = 0;
            int number = 0;
            int[] array = new int[N];
            for (int i = 0; i < N; i++)
                array[i] = i;
            for (int i = 0; i < N; i++)
                if (r > Math.Abs(array[i] - R))
                {
                    r = Math.Abs(array[i] - R);
                    number = array[i];
                }
            Console.WriteLine(number);
        }
        public static void Array41(int N)
        {
            int[] array = new int[N];
            for (int i = 0; i < N; i++)
            {
                array[i] = N - i;
                Console.WriteLine($"Number {i}: {N - i}");
            }
            int firstnumber = 0;
            int secondnumber = 0;
            for (int i = 1; i < N; i++)
            {
                if (array[i - 1] + array[i] > firstnumber + secondnumber)
                {
                    firstnumber = array[i - 1];
                    secondnumber = array[i];
                }
            }
            Console.WriteLine($"First number: {firstnumber}");
            Console.WriteLine($"Second number: {secondnumber}");
        }
        public static void Array42(int N, int R)
        {
            int firstnumber = 0;
            int secondnumber = 0;
            int[] array = new int[N];
            for (int i = 0; i < N; i++)
                array[i] = i;
            int r = Math.Abs(R - (array[1] + array[0]));
            for (int i = 2; i < N; i++)
                if (r > Math.Abs(R - (array[i - 1] + array[i])))
                {
                    r = Math.Abs(R - (array[i - 1] + array[i]));
                    firstnumber = array[i - 1];
                    secondnumber = array[i];
                }
            Console.WriteLine($"First number: {firstnumber}");
            Console.WriteLine($"Second number: {secondnumber}");
        }
        public static void Array43(int N)
        {
            int count = 0;
            int[] array = new int[N];
            for (int i = 0; i < N; i++)
                array[i] = i;
            int lastnumber = array[0];
            for (int i = 1; i < N; i++)
            {
                if (lastnumber != array[i] && i == 1)
                    count += 2;
                else if (lastnumber != array[i])
                    count++;
                lastnumber = array[i];
            }
        }
        public static void Array44(int N)
        {
            int[] array = new int[N];
            for (int i = 0; i < N; i++)
                array[i] = i;

            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                    if (array[i] == array[j])
                    {
                        if (i >= j) { Console.WriteLine(j); Console.WriteLine(i); }
                        else { Console.WriteLine(i); Console.WriteLine(j); }
                    }
        }
        public static void Array45(int N)
        {
            int firstindex = 0;
            int secondindex = 0;
            int[] array = new int[N];
            for (int i = 0; i < N; i++)
                array[i] = i;
            int r = Math.Abs(array[1] - array[0]);
            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                    if (r > Math.Abs(array[i] - array[j]))
                    {
                        r = Math.Abs(array[i] - array[j]);
                        firstindex = i;
                        secondindex = j;
                    }
            Console.WriteLine(firstindex);
            Console.WriteLine(secondindex);
        }
        public static void Array46(int R, int N)
        {
            int firstindex = 0;
            int secondindex = 0;
            int[] array = new int[N];
            for (int i = 0; i < N; i++)
                array[i] = i;
            int r = Math.Abs(R - (array[1] + array[0]));
            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                    if (r > Math.Abs(R - (array[i] + array[j])))
                    {
                        r = Math.Abs(R - (array[i] + array[j]));
                        if (i >= j) { firstindex = i; secondindex = j; }
                        else { firstindex = j; secondindex = i; }
                    }
            Console.WriteLine(firstindex);
            Console.WriteLine(secondindex);
        }
        public static void Array47(int N)
        {
            int count = 0;
            int[] array = new int[N];
            for (int i = 0; i < N; i++)
            {
                array[i] = rnd.Next(101);
                Console.WriteLine(array[i]);
            }
            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                    if (array[i] == array[j])
                        count++;
            int differCount = N - (count / 2);
            Console.WriteLine(differCount);
        }
        public static void Array48(int N)
        {
            int count = 0;
            int[] array = new int[N];
            for (int i = 0; i < N; i++)
            {
                array[i] = rnd.Next(101);
                Console.WriteLine(array[i]);
            }
            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                    if (array[i] == array[j])
                        count++;
            Console.WriteLine(count);
        }
        public static void Array49(int N)
        {
            int[] array = new int[N];
            for (int i = 0; i < N; i++)
            {
                array[i] = rnd.Next(101);
                Console.WriteLine(array[i]);
            }
            bool hasit = false;
            for (int i = 0; i < N; i++)
            {
                for (int j = 1; j <= N; j++)
                {
                    if (array[i] == j)
                        hasit = true;
                }
                if (!hasit)
                {
                    Console.WriteLine(i);
                    return;
                }
                else hasit = false;
            }
            Console.WriteLine(0);
        }
        public static void Array50(int N)
        {
            int count = 0;
            int[] array = new int[N];
            for (int i = 0; i < N; i++)
            {
                array[i] = rnd.Next(101);
                Console.WriteLine(array[i]);
            }
            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                    if (i < j && array[i] > array[j] || i > j && array[j] > array[i])
                        count++;
            Console.WriteLine(count);
        }
        //Работа с несколькими массивами
        public static void Array51(int N)
        {
            int[] array1 = new int[N];
            int[] array2 = new int[N];
            for (int i = 0; i < N; i++)
            {
                array1[i] = rnd.Next(101);
                array2[i] = rnd.Next(101);
                Console.WriteLine($"array1 {i}: {array1[i]}");
                Console.WriteLine($"array2 {i}: {array2[i]}");
            }
            int[] array3 = new int[N];
            for (int i = 0; i < N; i++)
                array3[i] = array1[i];

            for (int i = 0; i < N; i++)
            {
                array1[i] = array2[i];
                array2[i] = array3[i];
            }
            Console.WriteLine();
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"array1 {i}: {array1[i]}");
                Console.WriteLine($"array2 {i}: {array2[i]}");
            }
        }
        public static void Array52(int N)
        {
            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = rnd.Next(101);
                Console.WriteLine(A[i]);
            }
            int[] B = new int[N];
            Console.WriteLine();
            for (int i = 0; i < N; i++)
            {
                if (A[i] < 5)
                    B[i] = 2 * A[i];
                else B[i] = A[i] / 2;
                Console.WriteLine(B[i]);
            }
        }
        public static void Array53(int N)
        {
            int[] A = new int[N];
            int[] B = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = rnd.Next(101);
                B[i] = rnd.Next(101);
                Console.WriteLine($"array1 {i}: {A[i]}");
                Console.WriteLine($"array2 {i}: {B[i]}");
                Console.WriteLine();
            }
            Console.WriteLine();
            int[] C = new int[N];
            for (int i = 0; i < N; i++)
            {
                if (A[i] >= B[i])
                    C[i] = A[i];
                else C[i] = B[i];
                Console.WriteLine(C[i]);
            }
        }
        public static void Array54(int N)
        {
            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = rnd.Next(101);
                Console.WriteLine(A[i]);
            }
            Console.WriteLine();
            int[] B = new int[0];
            for (int i = 0; i < N; i++)
            {
                if (A[i] % 2 == 0)
                {
                    Array.Resize(ref B, B.Length + 1);
                    B[B.Length - 1] = A[i];
                    Console.WriteLine(B[B.Length - 1]);
                }
            }
        }
        public static void Array55(int N)
        {
            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = rnd.Next(101);
                Console.WriteLine($"{i}: {A[i]}");
            }
            Console.WriteLine();
            int length = N / 2;
            int[] B = new int[length];
            int counter = 0;
            for (int i = 1; i < N; i += 2)
            {
                B[counter] = A[i];
                counter++;
                Console.WriteLine(A[i]);
            }
        }
        public static void Array56(int N)
        {
            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = rnd.Next(101);
                Console.WriteLine($"{i}: {A[i]}");
            }
            Console.WriteLine();
            int length = N / 3;
            int[] B = new int[length];
            int counter = 0;
            for (int i = 3; i < N; i += 3)
            {
                B[counter] = A[i];
                Console.WriteLine(B[counter]);
                counter++;
            }
        }
        public static void Array57(int N)
        {
            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = rnd.Next(101);
                Console.WriteLine(A[i]);
            }
            Console.WriteLine();
            int[] B = new int[N];
            int counter = 0;
            for (int i = 0; i < N; i += 2)
            {
                B[counter] = A[i];
                Console.WriteLine(A[i]);
                counter++;
            }
            for (int i = 1; i < N; i += 2)
            {
                B[counter] = A[i];
                Console.WriteLine(A[i]);
                counter++;
            }
        }
        public static void Array58(int N)
        {
            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = rnd.Next(101);
                Console.WriteLine(A[i]);
            }
            Console.WriteLine();
            int[] B = new int[N];
            for (int i = 0; i < N; i++)
            {
                int sum = 0;
                for (int j = 0; j <= i; j++)
                {
                    sum += A[j];
                }
                B[i] = sum;
                Console.WriteLine(B[i]);
            }
        }
        public static void Array59(int N)
        {
            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = rnd.Next(101);
                Console.WriteLine(A[i]);
            }
            Console.WriteLine();
            int[] B = new int[N];
            for (int i = 0; i < N; i++)
            {
                int sum = 0;
                for (int j = 0; j <= i; j++)
                {
                    sum += A[j];
                }
                B[i] = sum / i;
                Console.WriteLine(B[i]);
            }
        }
        public static void Array60(int N)
        {
            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = rnd.Next(101);
                Console.WriteLine(A[i]);
            }
            Console.WriteLine();
            int[] B = new int[N];
            for (int i = 0; i < N; i++)
            {
                int sum = 0;
                for (int j = i; j < N; j++)
                {
                    sum += A[j];
                }
                B[i] = sum;
                Console.WriteLine(B[i]);
            }
        }
        public static void Array61(int N)
        {
            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = rnd.Next(101);
                Console.WriteLine(A[i]);
            }
            Console.WriteLine();
            int[] B = new int[N];
            for (int i = 0; i < N; i++)
            {
                int sum = 0;
                for (int j = i; j < N; j++)
                {
                    sum += A[j];
                }
                B[i] = sum / i;
                Console.WriteLine(B[i]);
            }
        }
        public static void Array62(int N)
        {
            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = rnd.Next(-100, 100);
                Console.WriteLine(A[i]);
            }
            Console.WriteLine();
            int[] B = new int[0];
            int[] C = new int[0];
            int b_counter = 0;
            int c_counter = 0;
            for (int i = 0; i < N; i++)
            {
                if (A[i] >= 0)
                {
                    Array.Resize(ref B, B.Length + 1);
                    B[b_counter] = A[i];
                    b_counter++;
                }
                else
                {
                    Array.Resize(ref C, C.Length + 1);
                    C[c_counter] = A[i];
                    c_counter++;
                }
            }
            Console.WriteLine();
            for (int i = 0; i < B.Length; i++)
            {
                Console.WriteLine(B[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < C.Length; i++)
            {
                Console.WriteLine(C[i]);
            }
        }
        public static void Array63()
        {
            int[] A = new int[5];
            int[] B = new int[5];
            for (int i = 0; i < 5; i++)
            {
                A[i] = rnd.Next(101);
                B[i] = rnd.Next(101);
                Console.WriteLine(A[i]);
                Console.WriteLine(B[i]);
                Console.WriteLine();
            }
            int[] C = new int[10];
            for (int i = 0; i < 10; i++)
            {
                if (i <= 4)
                    C[i] = A[i];
                else C[i] = B[i - 5];
            }

            for (int i = 0; i < 10; i++)
                for (int j = 1; j < 10; j++)
                    if (C[j - 1] > C[j])
                    {
                        int number = C[j];
                        C[j] = C[j - 1];
                        C[j - 1] = number;
                    }

            Console.WriteLine();
            for (int i = 0; i < 10; i++)
                Console.WriteLine(C[i]);
        }
        public static void Array64(int Na, int Nb, int Nc)
        {
            int[] A = new int[Na];
            int[] B = new int[Nb];
            int[] C = new int[Nc];
            for (int i = 0; i < Na; i++)
            {
                A[i] = rnd.Next(101);
                Console.WriteLine(A[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < Nb; i++)
            {
                B[i] = rnd.Next(101);
                Console.WriteLine(B[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < Nc; i++)
            {
                C[i] = rnd.Next(101);
                Console.WriteLine(C[i]);
            }

            int[] D = new int[Na + Nb + Nc];
            for (int i = 0; i < D.Length; i++)
            {
                if (i < Na)
                    D[i] = A[i];
                else if (i < Na + Nb)
                    D[i] = B[i - Na];
                else D[i] = C[i - (Na + Nb)];
            }

            for (int i = 0; i < D.Length; i++)
                for (int j = 1; j < D.Length; j++)
                    if (D[j - 1] < D[j])
                    {
                        int number = D[j];
                        D[j] = D[j - 1];
                        D[j - 1] = number;
                    }

            Console.WriteLine();
            for (int i = 0; i < D.Length; i++)
                Console.WriteLine(D[i]);
        }
        //Преобразование массива
        //Изминение элементов массива
        public static void Array65(int N, int K)
        {
            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = rnd.Next(101);
                Console.WriteLine(A[i]);
            }
            Console.WriteLine();
            int Ak = A[K];
            for (int i = 0; i < N; i++)
            {
                A[i] += Ak;
                Console.WriteLine(A[i]);
            }
        }
        public static void Array66(int N)
        {
            bool hasfound = false;
            int firsnumber = 0;
            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = rnd.Next(101);
                Console.WriteLine(A[i]);
            }
            for (int i = 0; i < N; i++)
            {
                if (A[i] % 2 == 0 && hasfound == false)
                {
                    firsnumber = A[i];
                    hasfound = true;
                    A[i] *= 2;
                    Console.WriteLine(A[i]);
                }
                else if (A[i] % 2 == 0)
                {
                    A[i] += firsnumber;
                    Console.WriteLine(A[i]);
                }
            }
        }
        public static void Array67(int N)
        {
            bool hasfound = false;
            int firsnumber = 0;
            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = rnd.Next(101);
                Console.WriteLine(A[i]);
            }
            for (int i = 0; i < N; i++)
            {
                if (A[i] % 2 != 0 && hasfound == false)
                {
                    firsnumber = A[i];
                    hasfound = true;
                    A[i] *= 2;
                    Console.WriteLine(A[i]);
                }
                else if (A[i] % 2 != 0)
                {
                    A[i] += firsnumber;
                    Console.WriteLine(A[i]);
                }
            }
        }
        public static void Array68(int N)
        {
            int min = 0;
            int max = 0;
            int min_index = 0;
            int max_index = 0;
            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = rnd.Next(101);
                Console.WriteLine(A[i]);
            }
            for (int i = 0; i < N; i++)
            {
                if (min > A[i])
                {
                    min = A[i];
                    min_index = i;
                }
                if (max < A[i])
                {
                    max = A[i];
                    max_index = i;
                }
            }
            A[min_index] = max;
            A[max_index] = min;
            Console.WriteLine(A[min_index]);
            Console.WriteLine(A[max_index]);
        }
        public static void Array69(int N)
        {
            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = rnd.Next(101);
                Console.WriteLine(A[i]);
            }
            for (int i = 1; i < N; i += 2)
            {
                int number = A[i - 1];
                A[i - 1] = A[i];
                A[i] = number;
                Console.WriteLine(A[i - 1]);
                Console.WriteLine(A[i]);
            }
        }
        public static void Array70(int N)
        {
            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = rnd.Next(101);
                Console.WriteLine(A[i]);
            }
            for (int i = 0; i < N / 2; i++)
            {
                int number = A[i];
                A[i] = A[i + N / 2];
                A[i + N / 2] = number;
                Console.WriteLine(A[i]);
                Console.WriteLine(A[i + N / 2]);
            }
        }
        public static void Array84(int N)
        {
            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = rnd.Next(101);
                Console.WriteLine(A[i]);
            }
            Console.WriteLine();
            int number = A[0];
            for (int i = 0; i < N - 1; i++)
            {
                A[i] = A[i + 1];
                Console.WriteLine(A[i]);
            }
            A[N - 1] = number;
            Console.WriteLine(number);
        }
        public static void Array85(int N, int K)
        {
            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = rnd.Next(101);
                Console.WriteLine(A[i]);
            }
            Console.WriteLine();
            int[] B = new int[4];
            B[0] = A[N - 1];
            B[1] = A[N - 2];
            B[2] = A[N - 3];
            B[3] = A[N - 4];
            int counter = 0;
            for (int i = N - 1; i >= 0; i--)
            {
                if (i - K >= 0)
                    A[i] = A[i - K];
                else { A[i] = B[counter]; counter++; }
            }
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(A[i]);
            }
        }
        public static void Array86(int N, int K)
        {
            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = rnd.Next(101);
                Console.WriteLine(A[i]);
            }
            Console.WriteLine();
            int[] B = new int[4];
            B[0] = A[0];
            B[1] = A[1];
            B[2] = A[2];
            B[3] = A[3];
            int counter = 0;
            for (int i = 0; i < N; i++)
            {
                if (i + K <= N)
                    A[i] = A[i + K];
                else { A[i] = B[counter]; counter++; }
                Console.WriteLine(A[i]);
            }
        }
        public static void Array87(int N)
        {
            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = rnd.Next(101);
                Console.WriteLine(A[i]);
            }
            Console.WriteLine();
            for (int i = 1; i < N; i++)
            {
                if (A[0] > A[i])
                {
                    int number = A[0];
                    A[0] = A[i];
                    A[i] = number;
                }
            }
        }
        public static void Array88(int N)
        {
            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = rnd.Next(101);
                Console.WriteLine(A[i]);
            }
            Console.WriteLine();
            for (int i = N - 2; i >= 0; i--)
            {
                if (A[N - 1] < A[i])
                {
                    int number = A[N - 1];
                    A[N - 1] = A[i];
                    A[i] = number;
                }
            }
        }
        public static void Array89(int N)
        {
            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = N - i;
            }
            A[5] = 2;
            for (int i = 0; i < N; i++)
                Console.WriteLine(A[i]);

            Console.WriteLine();
            for (int i = 1; i < N; i++)
                if (A[i - 1] < A[i])
                {
                    int index = i;
                    for (int j = i; j >= 0; j--)
                        if (A[index] > A[j])
                        {
                            int number = A[index];
                            A[index] = A[j];
                            A[j] = number;
                            index--;
                        }
                }
            for (int i = 0; i < N; i++)
                Console.WriteLine(A[i]);
        }
        public static void Array90(int N, int K)
        {
            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = rnd.Next(101);
                Console.WriteLine(A[i]);
            }
            int[] newA = new int[N - 1];
            Console.WriteLine();
            for (int i = 0; i < K; i++)
            {
                newA[i] = A[i];
                Console.WriteLine(newA[i]);
            }
            for (int i = K + 1; i < N; i++)
            {
                newA[i - 1] = A[i];
                Console.WriteLine(newA[i - 1]);
            }
        }
        public static void Array91(int N, int K, int L)
        {
            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = rnd.Next(101);
                Console.WriteLine(A[i]);
            }
            int[] newA = new int[N - (L - K + 1)];
            Console.WriteLine();
            for (int i = 0; i < K; i++)
            {
                newA[i] = A[i];
                Console.WriteLine(newA[i]);
            }
            for (int i = L + 1; i < N; i++)
            {
                newA[i - (K + 1)] = A[i];
                Console.WriteLine(newA[i - (K + 1)]);
            }
        }
        public static void Array92(int N)
        {
            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = rnd.Next(101);
                Console.WriteLine(A[i]);
            }
            int[] newA = new int[0];
            Console.WriteLine();
            for (int i = 0; i < N; i++)
            {
                if (A[i] % 2 == 1)
                {
                    Array.Resize(ref newA, newA.Length + 1);
                    newA[newA.Length - 1] = A[i];
                    Console.WriteLine(newA[newA.Length - 1]);
                }
            }
        }
        public static void Array93(int N)
        {
            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = rnd.Next(101);
                Console.WriteLine(A[i]);
            }
            int[] newA = new int[(N + 1) / 2];
            Console.WriteLine();
            int counter = 0;
            for (int i = 0; i < N; i += 2)
            {
                newA[counter] = A[i];
                Console.WriteLine(newA[counter]);
                counter++;
            }
        }
        public static void Array94(int N)
        {
            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = rnd.Next(101);
                Console.WriteLine(A[i]);
            }
            int[] newA = new int[N / 2];
            Console.WriteLine();
            int counter = 0;
            for (int i = 1; i < N; i += 2)
            {
                newA[counter] = A[i];
                Console.WriteLine(newA[counter]);
                counter++;
            }
        }
        public static void Array95(int N)
        {
            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = rnd.Next(101);
                Console.WriteLine(A[i]);
            }
            int[] newA = new int[1];
            newA[0] = A[0];
            Console.WriteLine();
            for (int i = 1; i < N; i++)
            {
                if (A[i - 1] != A[i])
                {
                    Array.Resize(ref newA, newA.Length + 1);
                    newA[newA.Length - 1] = A[i];
                    Console.WriteLine(newA[newA.Length - 1]);
                }
            }
        }
        public static void Array96(int N)
        {
            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = rnd.Next(101);
                Console.WriteLine(A[i]);
            }
            int[] newA = new int[1];
            newA[0] = A[0];
            Console.WriteLine();
            bool isequal = false;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < newA.Length; j++)
                {
                    if (A[i] == newA[j])
                        isequal = true;
                }
                if (isequal == false)
                {
                    Array.Resize(ref newA, newA.Length + 1);
                    newA[newA.Length - 1] = A[i];
                    Console.WriteLine(newA[newA.Length - 1]);
                    isequal = false;
                }
            }
        }
        public static void Array97(int N)
        {
            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = rnd.Next(101);
                Console.WriteLine(A[i]);
            }
            int[] newA = new int[1];
            newA[0] = A[0];
            Console.WriteLine();
            bool isequal = false;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < newA.Length; j++)
                {
                    if (A[i] == newA[j])
                        isequal = true;
                }
                if (isequal == false)
                {
                    Array.Resize(ref newA, newA.Length + 1);
                    newA[newA.Length - 1] = A[i];
                    Console.WriteLine(newA[newA.Length - 1]);
                    isequal = false;
                }
            }
        }
        public static void Array98(int N)
        {
            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = rnd.Next(101);
                Console.WriteLine(A[i]);
            }
            int[] newA = new int[0];
            Console.WriteLine();
            for (int i = 0; i < N; i++)
            {
                int count = 0;
                for (int j = 0; j < N; j++)
                {
                    if (A[i] == A[j] && i != j)
                        count++;
                }
                if (count == 3)
                {
                    Array.Resize(ref newA, newA.Length + 1);
                    newA[newA.Length - 1] = A[i];
                    Console.WriteLine(newA[newA.Length - 1]);
                }
            }
        }
        public static void Array99(int N)
        {
            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = rnd.Next(101);
                Console.WriteLine(A[i]);
            }
            int[] newA = new int[0];
            Console.WriteLine();
            for (int i = 0; i < N; i++)
            {
                int count = 0;
                for (int j = 0; j < N; j++)
                {
                    if (A[i] == A[j] && i != j)
                        count++;
                }
                if (count <= 2)
                {
                    Array.Resize(ref newA, newA.Length + 1);
                    newA[newA.Length - 1] = A[i];
                    Console.WriteLine(newA[newA.Length - 1]);
                }
            }
        }
        public static void Array100(int N)
        {
            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = rnd.Next(101);
                Console.WriteLine(A[i]);
            }
            int[] newA = new int[0];
            Console.WriteLine();
            for (int i = 0; i < N; i++)
            {
                int count = 0;
                for (int j = 0; j < N; j++)
                {
                    if (A[i] == A[j] && i != j)
                        count++;
                }
                if (count != 2)
                {
                    Array.Resize(ref newA, newA.Length + 1);
                    newA[newA.Length - 1] = A[i];
                    Console.WriteLine(newA[newA.Length - 1]);
                }
            }
        }
        public static void Array101(int N, int K)
        {
            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = rnd.Next(101);
                Console.WriteLine(A[i]);
            }
            int[] newA = new int[N + 1];
            Console.WriteLine();
            for (int i = N - 1; i >= K; i--)
            {
                newA[i + 1] = A[i];
            }
            newA[K] = 0;
            for (int i = 0; i < K; i++)
            {
                newA[i] = A[i];
            }
            for (int i = 0; i < newA.Length; i++)
                Console.WriteLine(newA[i]);
        }
        public static void Array102(int N, int K)
        {
            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = rnd.Next(101);
                Console.WriteLine(A[i]);
            }
            int[] newA = new int[N + 1];
            Console.WriteLine();
            for (int i = N - 1; i >= K + 1; i--)
            {
                newA[i + 1] = A[i];
            }
            newA[K + 1] = 0;
            for (int i = 0; i <= K; i++)
            {
                newA[i] = A[i];
            }
            for (int i = 0; i < newA.Length; i++)
                Console.WriteLine(newA[i]);
        }
        public static void Array103(int N)
        {

            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = rnd.Next(101);
                Console.WriteLine(A[i]);
            }
            int[] newA = new int[N + 2];
            Console.WriteLine();
            int min = A[0];
            int min_index = 0;
            int max = A[0];
            int max_index = 0;
            for (int i = 0; i < N; i++)
            {
                if (min > A[i])
                {
                    min = A[i];
                    min_index = i;
                }
                if (max < A[i])
                {
                    max = A[i];
                    max_index = i;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Minimum: {min}, index: {min_index}");
            Console.WriteLine($"Maximum: {max}, index: {max_index}");
            Console.WriteLine();
            if (min_index > max_index)
            {
                for (int i = 0; i <= max_index; i++)
                {
                    newA[i] = A[i];
                }
                newA[max_index + 1] = 0;
                for (int i = max_index + 2; i <= min_index; i++)
                {
                    newA[i] = A[i - 1];
                }
                newA[min_index + 1] = 0;
                for (int i = min_index + 2; i < newA.Length; i++)
                {
                    newA[i] = A[i - 2];
                }
            }
            else

            {
                for (int i = 0; i <= min_index - 1; i++)
                {
                    newA[i] = A[i];
                }
                newA[min_index] = 0;
                for (int i = min_index + 1; i <= max_index + 1; i++)
                {
                    newA[i] = A[i - 1];
                }
                newA[max_index + 2] = 0;
                for (int i = max_index + 3; i < newA.Length; i++)
                {
                    newA[i] = A[i - 2];
                }
            }
            foreach (var item in newA)
            {
                Console.WriteLine(item);
            }
        }
        public static void Array104(int N, int K, int M)
        {
            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = rnd.Next(101);
                Console.WriteLine(A[i]);
            }
            Console.WriteLine();
            int[] newA = new int[N + M];
            for (int i = 0; i <= K - 1; i++)
            {
                newA[i] = A[i];
            }
            for (int i = K; i < K + M - 1; i++)
            {
                newA[i] = 0;
            }
            for (int i = K + M; i < newA.Length; i++)
            {
                newA[i] = A[i - M];
            }
            for (int i = 0; i < newA.Length; i++)
                Console.WriteLine(newA[i]);
        }
        public static void Array105(int N, int K, int M)
        {
            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = rnd.Next(101);
                Console.WriteLine(A[i]);
            }
            Console.WriteLine();
            int[] newA = new int[N + M];
            for (int i = 0; i <= K; i++)
            {
                newA[i] = A[i];
            }
            for (int i = K + 1; i < K + M; i++)
            {
                newA[i] = 0;
            }
            for (int i = K + M + 1; i < newA.Length; i++)
            {
                newA[i] = A[i - M];
            }
            for (int i = 0; i < newA.Length; i++)
                Console.WriteLine(newA[i]);
        }
        public static void Array106(int N)
        {
            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = rnd.Next(101);
                Console.WriteLine(A[i]);
            }
            Console.WriteLine();
            int[] newA = new int[N + (N + 1) / 2];
            int counter = 0;
            for (int i = 0; i < N; i += 2)
            {
                newA[counter] = A[i];
                counter++;
                newA[counter] = A[i];
                counter += 2;
            }
            int counter2 = 2;
            for (int i = 1; i < N; i += 2)
            {
                newA[counter2] = A[i];
                counter2 += 3;
            }
            for (int i = 0; i < newA.Length; i++)
                Console.WriteLine(newA[i]);
        }
        public static void Array107(int N)
        {
            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = rnd.Next(101);
                Console.WriteLine(A[i]);
            }
            Console.WriteLine();
            int[] newA = new int[2 * N];
            int counter = 1;
            int counter2 = 0;
            for (int i = 0; i < N; i += 2)
            {
                newA[counter2] = A[i];
                counter2 += 4;
            }
            for (int i = 1; i < N; i += 2)
            {
                newA[counter] = A[i];
                counter++;
                newA[counter] = A[i];
                counter++;
                newA[counter] = A[i];
                counter += 2;
            }
            for (int i = 0; i < newA.Length; i++)
                Console.WriteLine(newA[i]);
        }
        public static void Array108(int N)
        {
            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = rnd.Next(-100, 100);
                Console.WriteLine(A[i]);
            }
            Console.WriteLine();
            Console.WriteLine("________________________________");
            Console.WriteLine();
            int count = 0;
            for (int i = 0; i < N; i++)
                if (A[i] >= 0)
                    count++;
            int[] newA = new int[N + count];
            int counter = 0;
            for (int i = 0; i < N; i++)
            {
                if (A[i] >= 0)
                {
                    newA[counter] = 0;
                    newA[counter + 1] = A[i];
                    counter += 2;
                }
                else
                {
                    newA[counter] = A[i];
                    counter++;
                }
            }
            for (int i = 0; i < newA.Length; i++)
                Console.WriteLine(newA[i]);
        }
        public static void Array109(int N)
        {
            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = rnd.Next(-100, 100);
                Console.WriteLine(A[i]);
            }
            Console.WriteLine("________________________________");
            int count = 0;
            for (int i = 0; i < N; i++)
                if (A[i] < 0)
                    count++;
            int[] newA = new int[N + count];
            int counter = 0;
            for (int i = 0; i < N; i++)
            {
                if (A[i] < 0)
                {
                    newA[counter] = A[i];
                    newA[counter + 1] = 0;
                    counter += 2;
                }
                else
                {
                    newA[counter] = A[i];
                    counter++;
                }
            }
            for (int i = 0; i < newA.Length; i++)
                Console.WriteLine(newA[i]);
        }
        public static void Array110(int N)
        {
            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = rnd.Next(101);
                Console.WriteLine(A[i]);
            }
            Console.WriteLine("__________________________");
            int count = 0;
            for (int i = 0; i < N; i++)
                if (A[i] % 2 == 0)
                    count++;
            int[] newA = new int[N + count];
            int counter = 0;
            for (int i = 0; i < N; i++)
            {
                if (A[i] % 2 == 0)
                {
                    newA[counter] = A[i];
                    newA[counter + 1] = A[i];
                    counter += 2;
                }
                else
                {
                    newA[counter] = A[i];
                    counter++;
                }
            }
            for (int i = 0; i < newA.Length; i++)
                Console.WriteLine(newA[i]);
        }
        public static void Array111(int N)
        {
            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = rnd.Next(101);
                Console.WriteLine(A[i]);
            }
            Console.WriteLine("__________________________");
            int count = 0;
            for (int i = 0; i < N; i++)
                if (A[i] % 2 == 1)
                    count++;
            int[] newA = new int[N + 2 * count];
            int counter = 0;
            for (int i = 0; i < N; i++)
            {
                if (A[i] % 2 == 1)
                {
                    newA[counter] = A[i];
                    newA[counter + 1] = A[i];
                    newA[counter + 2] = A[i];
                    counter += 3;
                }
                else
                {
                    newA[counter] = A[i];
                    counter++;
                }
            }
            for (int i = 0; i < newA.Length; i++)
                Console.WriteLine(newA[i]);
        }
        public static void Array112(int N)
        {
            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = rnd.Next(101);
                Console.WriteLine(A[i]);
            }
            Console.WriteLine("______________________");
            for (int i = 0; i < N; i++)
            {
                for (int j = 1; j < N; j++)
                {
                    if (A[j - 1] > A[j])
                    {
                        int number = A[j - 1];
                        A[j - 1] = A[j];
                        A[j] = number;
                    }
                }
            }
            for (int i = 0; i < N; i++)
                Console.WriteLine(A[i]);
        }
        public static void Array116(int N)
        {
            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = rnd.Next(1, 5);
                Console.WriteLine(A[i]);
            }
            Console.WriteLine("___________________");
            int[] B = new int[0];
            int[] C = new int[0];

            int counter = 1;
            int number = A[0];
            for (int i = 1; i < N; i++)
            {
                if (number == A[i])
                    counter++;
                else
                {
                    Array.Resize(ref B, B.Length + 1);
                    B[B.Length - 1] = counter;
                    Array.Resize(ref C, C.Length + 1);
                    C[C.Length - 1] = number;
                    number = A[i];
                    counter = 1;
                }
                if (i == N - 1)
                {
                    Array.Resize(ref B, B.Length + 1);
                    B[B.Length - 1] = counter;
                    Array.Resize(ref C, C.Length + 1);
                    C[C.Length - 1] = number;
                    counter = 1;
                }
            }
            for (int i = 0; i < B.Length; i++)
            {
                Console.WriteLine($"number of {C[i]} is {B[i]}");
            }
        }
        public static void Array117(int N)
        {
            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = rnd.Next(1, 5);
                Console.WriteLine(A[i]);
            }
            Console.WriteLine("__________________");
            int[] newA = new int[2];
            newA[0] = 0;
            newA[1] = A[0];
            int number = A[0];
            for (int i = 1; i < N; i++)
            {
                if (number != A[i])
                {
                    Array.Resize(ref newA, newA.Length + 2);
                    newA[newA.Length - 2] = 0;
                    newA[newA.Length - 1] = A[i];
                    number = A[i];
                }
                else
                {
                    Array.Resize(ref newA, newA.Length + 1);
                    newA[newA.Length - 1] = A[i];
                }
            }
            for (int i = 0; i < newA.Length; i++)
                Console.WriteLine(newA[i]);
        }
        public static void Array118(int N)
        {
            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = rnd.Next(1, 5);
                Console.WriteLine(A[i]);
            }
            Console.WriteLine("__________________");
            int[] newA = new int[1];
            newA[0] = A[0];
            int number = A[0];
            for (int i = 1; i < N; i++)
            {
                if (number != A[i])
                {
                    Array.Resize(ref newA, newA.Length + 2);
                    newA[newA.Length - 2] = 0;
                    newA[newA.Length - 1] = A[i];
                    number = A[i];
                }
                else
                {
                    Array.Resize(ref newA, newA.Length + 1);
                    newA[newA.Length - 1] = A[i];
                }
                if (i == N - 1)
                {
                    Array.Resize(ref newA, newA.Length + 1);
                    newA[newA.Length - 1] = 0;
                }
            }
            for (int i = 0; i < newA.Length; i++)
                Console.WriteLine(newA[i]);
        }
        public static void Array119(int N)
        {
            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = rnd.Next(1, 5);
                Console.WriteLine(A[i]);
            }
            Console.WriteLine("___________________________");
            int[] newA = new int[1];
            newA[0] = A[0];
            int number = A[0];
            for (int i = 1; i < N; i++)
            {
                if (number != A[i])
                {
                    Array.Resize(ref newA, newA.Length + 2);
                    newA[newA.Length - 2] = number;
                    newA[newA.Length - 1] = A[i];
                    number = A[i];
                }
                else
                {
                    Array.Resize(ref newA, newA.Length + 1);
                    newA[newA.Length - 1] = number;
                }
                if (i == N - 1)
                {
                    Array.Resize(ref newA, newA.Length + 1);
                    newA[newA.Length - 1] = A[i];
                }
            }
            for (int i = 0; i < newA.Length; i++)
                Console.WriteLine(newA[i]);
        }
        public static void Array120(int N)
        {
            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = rnd.Next(1, 5);
                Console.WriteLine(A[i]);
            }
            Console.WriteLine("______________________");
            int[] newA = new int[0];
            int number = A[0];
            int[] B = new int[0];
            int[] C = new int[0];
            int counter = 1;
            for (int i = 1; i < N; i++)
            {
                if (number == A[i])
                    counter++;
                else
                {
                    Array.Resize(ref B, B.Length + 1);
                    B[B.Length - 1] = counter;
                    Array.Resize(ref C, C.Length + 1);
                    C[C.Length - 1] = number;
                    number = A[i];
                    counter = 1;
                }
                if (i == N - 1)
                {
                    Array.Resize(ref B, B.Length + 1);
                    B[B.Length - 1] = counter;
                    Array.Resize(ref C, C.Length + 1);
                    C[C.Length - 1] = number;
                    counter = 1;
                }
            }

            for (int i = 0; i < B.Length; i++)
            {
                for (int j = 0; j < B[i] - 1; j++)
                {
                    Array.Resize(ref newA, newA.Length + 1);
                    newA[newA.Length - 1] = C[i];
                }
            }

            for (int i = 0; i < newA.Length; i++)
                Console.WriteLine(newA[i]);
        }
        public static void Array121(int N, int K)
        {
            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = rnd.Next(1, 5);
                Console.WriteLine(A[i]);
            }
            Console.WriteLine("______________________");
            int[] newA = new int[0];
            int number = A[0];
            int[] B = new int[0];
            int[] C = new int[0];
            int counter = 1;
            for (int i = 1; i < N; i++)
            {
                if (number == A[i])
                    counter++;
                else
                {
                    Array.Resize(ref B, B.Length + 1);
                    B[B.Length - 1] = counter;
                    Array.Resize(ref C, C.Length + 1);
                    C[C.Length - 1] = number;
                    number = A[i];
                    counter = 1;
                }
                if (i == N - 1)
                {
                    Array.Resize(ref B, B.Length + 1);
                    B[B.Length - 1] = counter;
                    Array.Resize(ref C, C.Length + 1);
                    C[C.Length - 1] = number;
                    counter = 1;
                }
            }

            for (int i = 0; i < B.Length; i++)
            {
                if (i == K)
                    for (int j = 0; j < B[i] * 2; j++)
                    {
                        Array.Resize(ref newA, newA.Length + 1);
                        newA[newA.Length - 1] = C[i];
                    }
                else
                    for (int j = 0; j < B[i]; j++)
                    {
                        Array.Resize(ref newA, newA.Length + 1);
                        newA[newA.Length - 1] = C[i];
                    }
            }

            for (int i = 0; i < newA.Length; i++)
                Console.WriteLine(newA[i]);
        }
        public static void Array122(int N, int K)
        {
            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = rnd.Next(1, 5);
                Console.WriteLine(A[i]);
            }
            Console.WriteLine("______________________");
            int[] newA = new int[0];
            int number = A[0];
            int[] B = new int[0];
            int[] C = new int[0];
            int counter = 1;
            for (int i = 1; i < N; i++)
            {
                if (number == A[i])
                    counter++;
                else
                {
                    Array.Resize(ref B, B.Length + 1);
                    B[B.Length - 1] = counter;
                    Array.Resize(ref C, C.Length + 1);
                    C[C.Length - 1] = number;
                    number = A[i];
                    counter = 1;
                }
                if (i == N - 1)
                {
                    Array.Resize(ref B, B.Length + 1);
                    B[B.Length - 1] = counter;
                    Array.Resize(ref C, C.Length + 1);
                    C[C.Length - 1] = number;
                    counter = 1;
                }
            }

            for (int i = 0; i < B.Length; i++)
            {
                if (i != K)
                    for (int j = 0; j < B[i]; j++)
                    {
                        Array.Resize(ref newA, newA.Length + 1);
                        newA[newA.Length - 1] = C[i];
                    }
            }

            for (int i = 0; i < newA.Length; i++)
                Console.WriteLine(newA[i]);
        }
        public static void Array123(int N, int K)
        {
            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = rnd.Next(1, 5);
                Console.WriteLine(A[i]);
            }
            Console.WriteLine("______________________");
            int[] newA = new int[0];
            int number = A[0];
            int[] B = new int[0];
            int[] C = new int[0];
            int counter = 1;
            for (int i = 1; i < N; i++)
            {
                if (number == A[i])
                    counter++;
                else
                {
                    Array.Resize(ref B, B.Length + 1);
                    B[B.Length - 1] = counter;
                    Array.Resize(ref C, C.Length + 1);
                    C[C.Length - 1] = number;
                    number = A[i];
                    counter = 1;
                }
                if (i == N - 1)
                {
                    Array.Resize(ref B, B.Length + 1);
                    B[B.Length - 1] = counter;
                    Array.Resize(ref C, C.Length + 1);
                    C[C.Length - 1] = number;
                    counter = 1;
                }
            }

            for (int i = 0; i < B.Length; i++)
            {
                if (i == 0)
                    for (int j = 0; j < B[K]; j++)
                    {
                        Array.Resize(ref newA, newA.Length + 1);
                        newA[newA.Length - 1] = C[K];
                    }
                else if (i == K)
                    for (int j = 0; j < B[0]; j++)
                    {
                        Array.Resize(ref newA, newA.Length + 1);
                        newA[newA.Length - 1] = C[0];
                    }
                else
                    for (int j = 0; j < B[i]; j++)
                    {
                        Array.Resize(ref newA, newA.Length + 1);
                        newA[newA.Length - 1] = C[i];
                    }
            }

            for (int i = 0; i < newA.Length; i++)
                Console.WriteLine(newA[i]);
        }
        public static void Array124(int N, int K)
        {
            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = rnd.Next(1, 5);
                Console.WriteLine(A[i]);
            }
            Console.WriteLine("______________________");
            int[] newA = new int[0];
            int number = A[0];
            int[] B = new int[0];
            int[] C = new int[0];
            int counter = 1;
            for (int i = 1; i < N; i++)
            {
                if (number == A[i])
                    counter++;
                else
                {
                    Array.Resize(ref B, B.Length + 1);
                    B[B.Length - 1] = counter;
                    Array.Resize(ref C, C.Length + 1);
                    C[C.Length - 1] = number;
                    number = A[i];
                    counter = 1;
                }
                if (i == N - 1)
                {
                    Array.Resize(ref B, B.Length + 1);
                    B[B.Length - 1] = counter;
                    Array.Resize(ref C, C.Length + 1);
                    C[C.Length - 1] = number;
                    counter = 1;
                }
            }

            for (int i = 0; i < B.Length; i++)
            {
                if (i == B.Length - 1)
                    for (int j = 0; j < B[K]; j++)
                    {
                        Array.Resize(ref newA, newA.Length + 1);
                        newA[newA.Length - 1] = C[K];
                    }
                else if (i == K)
                    for (int j = 0; j < B[B.Length - 1]; j++)
                    {
                        Array.Resize(ref newA, newA.Length + 1);
                        newA[newA.Length - 1] = C[B.Length - 1];
                    }
                else
                    for (int j = 0; j < B[i]; j++)
                    {
                        Array.Resize(ref newA, newA.Length + 1);
                        newA[newA.Length - 1] = C[i];
                    }
            }

            for (int i = 0; i < newA.Length; i++)
                Console.WriteLine(newA[i]);
        }
        public static void Array125(int N, int L)
        {
            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = rnd.Next(1, 5);
                Console.WriteLine(A[i]);
            }
            Console.WriteLine("______________________");
            int[] newA = new int[0];
            int number = A[0];
            int[] B = new int[0];
            int[] C = new int[0];
            int counter = 1;
            for (int i = 1; i < N; i++)
            {
                if (number == A[i])
                    counter++;
                else
                {
                    Array.Resize(ref B, B.Length + 1);
                    B[B.Length - 1] = counter;
                    Array.Resize(ref C, C.Length + 1);
                    C[C.Length - 1] = number;
                    number = A[i];
                    counter = 1;
                }
                if (i == N - 1)
                {
                    Array.Resize(ref B, B.Length + 1);
                    B[B.Length - 1] = counter;
                    Array.Resize(ref C, C.Length + 1);
                    C[C.Length - 1] = number;
                    counter = 1;
                }
            }

            for (int i = 0; i < B.Length; i++)
            {
                if (B[i] < L)
                {
                    Array.Resize(ref newA, newA.Length + 1);
                    newA[newA.Length - 1] = 0;
                }
                else
                {
                    for (int j = 0; j < B[i]; j++)
                    {
                        Array.Resize(ref newA, newA.Length + 1);
                        newA[newA.Length - 1] = C[i];
                    }
                }
            }

            for (int i = 0; i < newA.Length; i++)
                Console.WriteLine(newA[i]);
        }
        public static void Array126(int N, int L)
        {
            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = rnd.Next(1, 5);
                Console.WriteLine(A[i]);
            }
            Console.WriteLine("______________________");
            int[] newA = new int[0];
            int number = A[0];
            int[] B = new int[0];
            int[] C = new int[0];
            int counter = 1;
            for (int i = 1; i < N; i++)
            {
                if (number == A[i])
                    counter++;
                else
                {
                    Array.Resize(ref B, B.Length + 1);
                    B[B.Length - 1] = counter;
                    Array.Resize(ref C, C.Length + 1);
                    C[C.Length - 1] = number;
                    number = A[i];
                    counter = 1;
                }
                if (i == N - 1)
                {
                    Array.Resize(ref B, B.Length + 1);
                    B[B.Length - 1] = counter;
                    Array.Resize(ref C, C.Length + 1);
                    C[C.Length - 1] = number;
                    counter = 1;
                }
            }

            for (int i = 0; i < B.Length; i++)
            {
                if (B[i] == L)
                {
                    Array.Resize(ref newA, newA.Length + 1);
                    newA[newA.Length - 1] = 0;
                }
                else
                {
                    for (int j = 0; j < B[i]; j++)
                    {
                        Array.Resize(ref newA, newA.Length + 1);
                        newA[newA.Length - 1] = C[i];
                    }
                }
            }

            for (int i = 0; i < newA.Length; i++)
                Console.WriteLine(newA[i]);
        }
        public static void Array127(int N, int L)
        {
            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = rnd.Next(1, 5);
                Console.WriteLine(A[i]);
            }
            Console.WriteLine("______________________");
            int[] newA = new int[0];
            int number = A[0];
            int[] B = new int[0];
            int[] C = new int[0];
            int counter = 1;
            for (int i = 1; i < N; i++)
            {
                if (number == A[i])
                    counter++;
                else
                {
                    Array.Resize(ref B, B.Length + 1);
                    B[B.Length - 1] = counter;
                    Array.Resize(ref C, C.Length + 1);
                    C[C.Length - 1] = number;
                    number = A[i];
                    counter = 1;
                }
                if (i == N - 1)
                {
                    Array.Resize(ref B, B.Length + 1);
                    B[B.Length - 1] = counter;
                    Array.Resize(ref C, C.Length + 1);
                    C[C.Length - 1] = number;
                    counter = 1;
                }
            }

            for (int i = 0; i < B.Length; i++)
            {
                if (B[i] > L)
                {
                    Array.Resize(ref newA, newA.Length + 1);
                    newA[newA.Length - 1] = 0;
                }
                else
                {
                    for (int j = 0; j < B[i]; j++)
                    {
                        Array.Resize(ref newA, newA.Length + 1);
                        newA[newA.Length - 1] = C[i];
                    }
                }
            }

            for (int i = 0; i < newA.Length; i++)
                Console.WriteLine(newA[i]);
        }
        public static void Array128(int N)
        {
            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = rnd.Next(1, 5);
                Console.WriteLine(A[i]);
            }
            Console.WriteLine("______________________");
            int[] newA = new int[0];
            int number = A[0];
            int[] B = new int[0];
            int[] C = new int[0];
            int counter = 1;
            for (int i = 1; i < N; i++)
            {
                if (number == A[i])
                    counter++;
                else
                {
                    Array.Resize(ref B, B.Length + 1);
                    B[B.Length - 1] = counter;
                    Array.Resize(ref C, C.Length + 1);
                    C[C.Length - 1] = number;
                    number = A[i];
                    counter = 1;
                }
                if (i == N - 1)
                {
                    Array.Resize(ref B, B.Length + 1);
                    B[B.Length - 1] = counter;
                    Array.Resize(ref C, C.Length + 1);
                    C[C.Length - 1] = number;
                    counter = 1;
                }
            }
            int index = 0;
            int max = 0;
            for (int i = 0; i < B.Length; i++)
            {
                if (max < B[i])
                {
                    max = B[i];
                    index = i;
                }
            }

            for (int i = 0; i < B.Length; i++)
            {
                if (i == index)
                    for (int j = 0; j < B[i] + 1; j++)
                    {
                        Array.Resize(ref newA, newA.Length + 1);
                        newA[newA.Length - 1] = C[i];
                    }
                else
                    for (int j = 0; j < B[i]; j++)
                    {
                        Array.Resize(ref newA, newA.Length + 1);
                        newA[newA.Length - 1] = C[i];
                    }
            }
            for (int i = 0; i < newA.Length; i++)
                Console.WriteLine(newA[i]);
        }
        public static void Array129(int N)
        {
            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = rnd.Next(1, 5);
                Console.WriteLine(A[i]);
            }
            Console.WriteLine("______________________");
            int[] newA = new int[0];
            int number = A[0];
            int[] B = new int[0];
            int[] C = new int[0];
            int counter = 1;
            for (int i = 1; i < N; i++)
            {
                if (number == A[i])
                    counter++;
                else
                {
                    Array.Resize(ref B, B.Length + 1);
                    B[B.Length - 1] = counter;
                    Array.Resize(ref C, C.Length + 1);
                    C[C.Length - 1] = number;
                    number = A[i];
                    counter = 1;
                }
                if (i == N - 1)
                {
                    Array.Resize(ref B, B.Length + 1);
                    B[B.Length - 1] = counter;
                    Array.Resize(ref C, C.Length + 1);
                    C[C.Length - 1] = number;
                    counter = 1;
                }
            }
            int index = 0;
            int max = 0;
            for (int i = 0; i < B.Length; i++)
            {
                if (max <= B[i])
                {
                    max = B[i];
                    index = i;
                }
            }

            for (int i = 0; i < B.Length; i++)
            {
                if (i == index)
                    for (int j = 0; j < B[i] + 1; j++)
                    {
                        Array.Resize(ref newA, newA.Length + 1);
                        newA[newA.Length - 1] = C[i];
                    }
                else
                    for (int j = 0; j < B[i]; j++)
                    {
                        Array.Resize(ref newA, newA.Length + 1);
                        newA[newA.Length - 1] = C[i];
                    }
            }
            for (int i = 0; i < newA.Length; i++)
                Console.WriteLine(newA[i]);
        }
        public static void Array130(int N)
        {
            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = rnd.Next(1, 5);
                Console.WriteLine(A[i]);
            }
            Console.WriteLine("______________________");
            int[] newA = new int[0];
            int number = A[0];
            int[] B = new int[0];
            int[] C = new int[0];
            int counter = 1;
            for (int i = 1; i < N; i++)
            {
                if (number == A[i])
                    counter++;
                else
                {
                    Array.Resize(ref B, B.Length + 1);
                    B[B.Length - 1] = counter;
                    Array.Resize(ref C, C.Length + 1);
                    C[C.Length - 1] = number;
                    number = A[i];
                    counter = 1;
                }
                if (i == N - 1)
                {
                    Array.Resize(ref B, B.Length + 1);
                    B[B.Length - 1] = counter;
                    Array.Resize(ref C, C.Length + 1);
                    C[C.Length - 1] = number;
                    counter = 1;
                }
            }
            int max = 0;
            for (int i = 0; i < B.Length; i++)
            {
                if (max < B[i])
                {
                    max = B[i];
                }
            }

            for (int i = 0; i < B.Length; i++)
            {
                if (max == B[i])
                {
                    for (int l = 0; l < B[i] + 1; l++)
                    {
                        Array.Resize(ref newA, newA.Length + 1);
                        newA[newA.Length - 1] = C[i];
                    }
                }
                else
                    for (int l = 0; l < B[i]; l++)
                    {
                        Array.Resize(ref newA, newA.Length + 1);
                        newA[newA.Length - 1] = C[i];
                    }
            }
            for (int i = 0; i < newA.Length; i++)
                Console.WriteLine(newA[i]);
        }
        public static void Array131(int N, int x, int y)
        {
            int[] X = new int[N];
            int[] Y = new int[N];
            for (int i = 0; i < N; i++)
            {
                X[i] = rnd.Next(1, 5);
                X[i] = rnd.Next(1, 5);
            }
            double R = 0;
            for (int i = 0; i < N; i++)
            {
                double R2 = Math.Sqrt(Math.Pow((X[i] - x), 2) + Math.Pow((Y[i] - y), 2));
                if (R > R2)
                {
                    R = R2;
                }
            }
            Console.WriteLine(R);
        }

    }
}
