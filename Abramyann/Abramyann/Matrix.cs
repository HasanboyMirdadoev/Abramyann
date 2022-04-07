using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abramyann
{
    class Matrix
    {
        static Random rnd = new Random();
        public static void Matrix1(int N, int M)
        {
            int[,] array = new int[N, M];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    array[i, j] = i * 10;
                    Console.Write(array[i, j]);
                }
                Console.WriteLine();
            }
        }
        public static void Matrix2(int N, int M)
        {
            int[,] array = new int[N, M];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    array[i, j] = j * 5;
                    Console.Write(array[i, j]);
                }
                Console.WriteLine();
            }
        }
        public static void Matrix3(int M, int N)
        {
            int[] A = new int[M];
            for (int i = 0; i < M; i++)
            {
                A[i] = rnd.Next(101);
                Console.WriteLine(A[i]);
            }
            Console.WriteLine();
            int[,] array = new int[M, N];
            for (int i = 0; i < N; i++)
                for (int j = 0; j < M; j++)
                    array[j, i] = A[j];
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                    Console.Write(array[i, j]);
                Console.WriteLine();
            }
        }
        public static void Matrix4(int M, int N)
        {
            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = rnd.Next(10, 100);
                Console.WriteLine(A[i]);
            }
            Console.WriteLine();
            int[,] array = new int[M, N];
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    array[i, j] = A[j];
                    Console.Write(A[j]);
                }
                Console.WriteLine();
            }
        }
        public static void Matrix5(int M, int N, int D)
        {
            int[] A = new int[M];
            for (int i = 0; i < M; i++)
            {
                A[i] = rnd.Next(101);
                Console.WriteLine(A[i]);
            }
            Console.WriteLine();
            int[,] array = new int[M, N];
            for (int i = 0; i < N; i++)
                for (int j = 0; j < M; j++)
                    array[j, i] = A[j] + i * D;
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(array[i, j]);
                }
                Console.WriteLine();
            }
        }
        public static void Matrix6(int M, int N, int Q)
        {
            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = rnd.Next(101);
                Console.WriteLine(A[i]);
            }
            Console.WriteLine();
            int[,] array = new int[M, N];
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (i != 0)
                        array[i, j] = A[j] * i * Q;
                    else array[i, j] = A[j];
                    Console.Write($"{array[i, j]}|");
                }
                Console.WriteLine();
            }
        }
        public static void Matrix7(int M, int N, int K)
        {
            int[,] matrix = new int[M, N];
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matrix[i, j] = rnd.Next(10, 100);
                    Console.Write($"{matrix[i, j]}|");
                }
                Console.WriteLine();
            }
            Console.WriteLine("____________________");
            for (int i = 0; i < N; i++)
            {
                Console.Write($"{matrix[K, i]}|");
            }
        }
        public static void Matrix8(int M, int N, int K)
        {
            int[,] matrix = new int[M, N];
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matrix[i, j] = rnd.Next(10, 100);
                    Console.Write($"{matrix[i, j]}|");
                }
                Console.WriteLine();
            }
            Console.WriteLine("____________________");
            for (int i = 0; i < M; i++)
            {
                Console.WriteLine($"{matrix[i, K]}|");
            }
        }
        public static void Matrix9(int M, int N)
        {
            int[,] matrix = new int[M, N];
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matrix[i, j] = rnd.Next(10, 100);
                    Console.Write($"{matrix[i, j]}|");
                }
                Console.WriteLine();
            }
            Console.WriteLine("____________________");
            for (int i = 0; i < M; i += 2)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write($"{matrix[i, j]}|");
                }
                Console.WriteLine();
            }
        }
        public static void Matrix10(int M, int N)
        {
            int[,] matrix = new int[M, N];
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matrix[i, j] = rnd.Next(10, 100);
                    Console.Write($"{matrix[i, j]}|");
                }
                Console.WriteLine();
            }
            Console.WriteLine("____________________");
            for (int i = 0; i < M; i++)
            {
                for (int j = 1; j < N; j += 2)
                {
                    Console.Write($"{matrix[i, j]}|");
                }
                Console.WriteLine();
            }
        }
        public static void Matrix11(int M, int N)
        {
            int[,] matrix = new int[M, N];
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matrix[i, j] = rnd.Next(10, 100);
                    Console.Write($"{matrix[i, j]}|");
                }
                Console.WriteLine();
            }
            Console.WriteLine("____________________");
            for (int i = 0; i < M; i++)
            {
                if (i % 2 == 0)
                    for (int j = 0; j < N; j++)
                        Console.Write($"{matrix[i, j]}|");
                else
                    for (int j = N - 1; j >= 0; j--)
                        Console.Write($"{matrix[i, j]}|");
                Console.WriteLine();
            }
        }
        public static void Matrix12(int M, int N)
        {
            int[,] matrix = new int[M, N];
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matrix[i, j] = rnd.Next(10, 100);
                    Console.Write($"{matrix[i, j]}|");
                }
                Console.WriteLine();
            }
            Console.WriteLine("____________________");
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (j % 2 == 0)
                        Console.Write($"{matrix[i, j]}|");
                    else
                        Console.Write($"{matrix[M - 1 - i, j]}|");
                }
                Console.WriteLine();
            }
        }
        public static void Matrix13(int M)
        {
            int[,] A = new int[M, M];
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    A[i, j] = rnd.Next(10, 100);
                    Console.Write(A[i, j] + "|");
                }
                Console.WriteLine();
            }
            Console.WriteLine("________________");
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < M - i; j++)
                {
                    Console.Write(A[i, j] + "|");
                }
                Console.WriteLine();
                for (int j = i + 1; j < M; j++)
                {
                    Console.WriteLine(A[j, M - i - 1]);
                }
            }
        }
        public static void Matrix14(int M)
        {
            int[,] A = new int[M, M];
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    A[i, j] = rnd.Next(10, 100);
                    Console.Write(A[i, j] + "|");
                }
                Console.WriteLine();
            }
            Console.WriteLine("________________");
            for (int i = M - 1; i >= 0; i--)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.WriteLine(A[j, i]);
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write(A[i, j] + "|");
                }
                Console.WriteLine();
            }
        }
        public static void Matrix15(int M)
        {
            int[,] A = new int[M, M];
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    A[i, j] = rnd.Next(10, 100);
                    Console.Write(A[i, j] + "|");
                }
                Console.WriteLine();
            }
            Console.WriteLine("________________");
            for (int i = 0; i < M - 2; i++)
            {
                for (int j = i; j < M - i; j++)
                {
                    Console.Write(A[i, j] + "|");
                }
                Console.WriteLine();
                for (int j = i + 1; j < M - i; j++)
                {
                    Console.WriteLine(A[j, M - 1 - i]);
                }
                for (int j = M - 2 - i; j >= i; j--)
                {
                    Console.Write(A[M - 1 - i, j] + "|");
                }
                Console.WriteLine();
                for (int j = M - 2 - i; j > i; j--)
                {
                    Console.WriteLine(A[j, i]);
                }
                Console.WriteLine("________________");
            }
        }
        public static void Matrix16(int M)
        {
            int[,] A = new int[M, M];
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    A[i, j] = rnd.Next(10, 100);
                    Console.Write(A[i, j] + "|");
                }
                Console.WriteLine();
            }
            Console.WriteLine("________________");
            for (int i = 0; i < M / 2; i++)
            {
                for (int j = i; j < M - i; j++)
                {
                    Console.WriteLine(A[j, i]);
                }
                for (int j = i + 1; j < M - i; j++)
                {
                    Console.Write(A[M - 1 - i, j] + "|");
                }
                Console.WriteLine();
                for (int j = M - 2 - i; j >= i; j--)
                {
                    Console.WriteLine(A[j, M - 1 - i]);
                }
                for (int j = M - 2 - i; j >= i + 1; j--)
                {
                    Console.Write(A[i, j] + "|");
                }
                Console.WriteLine();
                Console.WriteLine("________________");
            }
        }
        public static void Matrix17(int N, int M, int K)
        {
            int[,] A = new int[M, N];
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    A[i, j] = rnd.Next(10, 100);
                    Console.Write(A[i, j] + "|");
                }
                Console.WriteLine();
            }
            Console.WriteLine("________________");
            int sum = 0;
            int multy = 1;
            for (int i = 0; i < N; i++)
            {
                sum += A[K, i];
                multy *= A[K, i];
            }
            Console.WriteLine($"Sum of numbers: {sum}");
            Console.WriteLine($"Multiplication of numbers: {multy}");
        }
        public static void Matrix18(int N, int M, int K)
        {
            int[,] A = new int[M, N];
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    A[i, j] = rnd.Next(10, 100);
                    Console.Write(A[i, j] + "|");
                }
                Console.WriteLine();
            }
            Console.WriteLine("________________");
            int sum = 0;
            int multy = 1;
            for (int i = 0; i < M; i++)
            {
                sum += A[i, K];
                multy *= A[i, K];
            }
            Console.WriteLine($"Sum of numbers: {sum}");
            Console.WriteLine($"Multiplication of numbers: {multy}");
        }
        public static void Matrix19(int N, int M)
        {
            int[,] A = new int[M, N];
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    A[i, j] = rnd.Next(10, 100);
                    Console.Write(A[i, j] + "|");
                }
                Console.WriteLine();
            }
            Console.WriteLine("________________");
            for (int i = 0; i < M; i++)
            {
                int sum = 0;
                int multy = 1;
                for (int j = 0; j < N; j++)
                {
                    sum += A[i, j];
                    multy *= A[i, j];
                }
                Console.WriteLine($"Sum of numbers: {sum}");
                Console.WriteLine($"Multiplication of numbers: {multy}");
                Console.WriteLine("____________________________________________");
                sum = 0;
                multy = 1;
            }
        }
        public static void Matrix20(int M, int N)
        {
            int[,] A = new int[M, N];
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    A[i, j] = rnd.Next(10, 100);
                    Console.Write(A[i, j] + "|");
                }
                Console.WriteLine();
            }
            Console.WriteLine("________________");
            for (int i = 0; i < N; i++)
            {
                int sum = 0;
                int multy = 1;
                for (int j = 0; j < M; j++)
                {
                    sum += A[j, i];
                    multy *= A[j, i];
                }
                Console.WriteLine($"Sum of numbers: {sum}");
                Console.WriteLine($"Multiplication of numbers: {multy}");
                Console.WriteLine("____________________________________________");
                sum = 0;
                multy = 1;
            }
        }
        public static void Matrix21(int M, int N)
        {
            int[,] A = new int[M, N];
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    A[i, j] = rnd.Next(10, 100);
                    Console.Write(A[i, j] + "|");
                }
                Console.WriteLine();
            }
            Console.WriteLine("________________");
            for (int i = 0; i < M; i++)
            {
                int sum = 0;
                for (int j = 1; j < N; j += 2)
                {
                    sum += A[i, j];
                }
                Console.WriteLine($"The avarage sum of items of {i} is: {sum / (N / 2)}");
            }
        }
        public static void Matrix22(int M, int N)
        {
            int[,] A = new int[M, N];
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    A[i, j] = rnd.Next(10, 100);
                    Console.Write(A[i, j] + "|");
                }
                Console.WriteLine();
            }
            Console.WriteLine("________________");
            for (int i = 0; i < N; i++)
            {
                int sum = 0;
                for (int j = 0; j < M; j += 2)
                {
                    sum += A[j, i];
                }
                Console.WriteLine($"The avarage sum of items of {i} is: {sum / ((M + 1) / 2)}");
            }
        }
        public static void Matrix23(int M, int N)
        {
            int[,] A = new int[M, N];
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    A[i, j] = rnd.Next(10, 100);
                    Console.Write(A[i, j] + "|");
                }
                Console.WriteLine();
            }
            Console.WriteLine("________________");
            for (int i = 0; i < M; i++)
            {
                int min = A[i, 0];
                for (int j = 0; j < N; j++)
                    if (min > A[i, j]) min = A[i, j];
                Console.WriteLine($"The minimum item in {i} is {min}");
            }
        }
        public static void Matrix24(int M, int N)
        {
            int[,] A = new int[M, N];
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    A[i, j] = rnd.Next(10, 100);
                    Console.Write(A[i, j] + "|");
                }
                Console.WriteLine();
            }
            Console.WriteLine("________________");
            for (int i = 0; i < N; i++)
            {
                int max = A[0, i];
                for (int j = 0; j < M; j++)
                    if (max < A[j, i]) max = A[j, i];
                Console.WriteLine(max);
            }
        }
        public static void Matrix25(int M, int N)
        {
            int[,] A = new int[M, N];
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    A[i, j] = rnd.Next(10, 100);
                    Console.Write(A[i, j] + "|");
                }
                Console.WriteLine();
            }
            int maxsum = 0;
            Console.WriteLine("________________");
            for (int i = 0; i < M; i++)
            {
                int sum = 0;
                for (int j = 0; j < N; j++)
                    sum += A[i, j];
                if (sum > maxsum) maxsum = sum;
                Console.WriteLine(sum);
            }
            Console.WriteLine("_______________");
            Console.WriteLine(maxsum);
        }
        public static void Matrix26(int M, int N)
        {
            int[,] A = new int[M, N];
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    A[i, j] = rnd.Next(10, 100);
                    Console.Write(A[i, j] + "|");
                }
                Console.WriteLine();
            }
            int minmulty = 0;
            int index = -1;
            Console.WriteLine("________________");
            for (int i = 0; i < N; i++)
            {
                int multiple = 0;
                for (int j = 0; j < M; j++)
                    multiple += A[j, i];
                if (multiple < minmulty) { minmulty = multiple; index = i; }
                Console.WriteLine(multiple);
            }
            Console.WriteLine("_______________");
            Console.WriteLine(minmulty);
            Console.WriteLine(index);
        }
        public static void Matrix27(int M, int N)
        {
            int[,] A = new int[M, N];
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    A[i, j] = rnd.Next(10, 100);
                    Console.Write(A[i, j] + "|");
                }
                Console.WriteLine();
            }
            int maxsum = 0;
            for (int i = 0; i < N; i++)
            {
                maxsum += A[0, i];
            }
            int index = 0;
            Console.WriteLine("________________");
            for (int i = 1; i < M; i++)
            {
                int sum = 0;
                for (int j = 0; j < N; j++)
                    sum += A[i, j];
                if (sum < maxsum) { maxsum = sum; index = i; }
                Console.WriteLine(sum);
            }
            Console.WriteLine("_______________");
            Console.WriteLine(maxsum);
            int max = 0;
            for (int i = 0; i < N; i++)
                if (max < A[index, i]) max = A[index, i];
            Console.WriteLine(max);
        }
        public static void Matrix28(int M, int N)
        {
            int[,] A = new int[M, N];
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    A[i, j] = rnd.Next(10, 100);
                    Console.Write(A[i, j] + "|");
                }
                Console.WriteLine();
            }
            int minsum = 0;
            int index = -1;
            Console.WriteLine("________________");
            for (int i = 0; i < N; i++)
            {
                int sum = 0;
                for (int j = 0; j < M; j++)
                    sum += A[j, i];
                if (sum > minsum) { minsum = sum; index = i; }
                Console.WriteLine(sum);
            }
            Console.WriteLine("_______________");
            Console.WriteLine(minsum);
            Console.WriteLine(index);
            Console.WriteLine("_______________");
            int min = A[0, index];
            for (int i = 0; i < M; i++)
                if (min > A[i, index]) min = A[i, index];
            Console.WriteLine(min);
        }
        public static void Matrix29(int M, int N)
        {
            int[,] A = new int[M, N];
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    A[i, j] = rnd.Next(10, 100);
                    Console.Write(A[i, j] + "|");
                }
                Console.WriteLine();
            }
            Console.WriteLine("________________");
            for (int i = 0; i < M; i++)
            {
                int sum = 0;
                for (int j = 0; j < N; j++)
                    sum += A[i, j];
                double avarage = sum / N;
                Console.WriteLine(avarage);
                int counter = 0;
                for (int j = 0; j < N; j++)
                    if (A[i, j] < avarage) counter++;
                Console.WriteLine(counter);
                Console.WriteLine("_______________");
            }
        }
        public static void Matrix47(int M, int N, int K1, int K2)
        {
            int[,] A = new int[M, N];
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    A[i, j] = rnd.Next(10, 100);
                    Console.Write(A[i, j] + "|");
                }
                Console.WriteLine();
            }
            Console.WriteLine("________________");
            int[] array = new int[N];
            for (int i = 0; i < N; i++)
            {
                array[i] = A[K1, i];
                A[K1, i] = A[K2, i];
                A[K2, i] = array[i];
            }
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(A[i, j] + "|");
                }
                Console.WriteLine();
            }
        }
        public static void Matrix48(int M, int N, int K1, int K2)
        {
            int[,] A = new int[M, N];
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    A[i, j] = rnd.Next(10, 100);
                    Console.Write(A[i, j] + "|");
                }
                Console.WriteLine();
            }
            Console.WriteLine("________________");
            int[] array = new int[M];
            for (int i = 0; i < M; i++)
            {
                array[i] = A[i, K1];
                A[i, K1] = A[i, K2];
                A[i, K2] = array[i];
            }
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(A[i, j] + "|");
                }
                Console.WriteLine();
            }
        }
        public static void Matrix49(int M, int N)
        {
            int[,] A = new int[M, N];
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    A[i, j] = rnd.Next(10, 100);
                    Console.Write(A[i, j] + "|");
                }
                Console.WriteLine();
            }
            Console.WriteLine("________________");
            for (int i = 0; i < M; i++)
            {
                int min = A[i, 0];
                int max = min;
                int min_index = 0;
                int max_index = 0;
                for (int j = 0; j < N; j++)
                {
                    if (min > A[i, j])
                    {
                        min = A[i, j];
                        min_index = j;
                    }
                    if (max < A[i, j])
                    {
                        max = A[i, j];
                        max_index = j;
                    }
                }
                A[i, min_index] = max;
                A[i, max_index] = min;
            }
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(A[i, j] + "|");
                }
                Console.WriteLine();
            }
        }
        public static void Matrix50(int M, int N)
        {
            int[,] A = new int[M, N];
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    A[i, j] = rnd.Next(10, 100);
                    Console.Write(A[i, j] + "|");
                }
                Console.WriteLine();
            }
            Console.WriteLine("________________");
            for (int i = 0; i < N; i++)
            {
                int min = A[0, i];
                int max = min;
                int min_index = 0;
                int max_index = 0;
                for (int j = 0; j < M; j++)
                {
                    if (min > A[j, i])
                    {
                        min = A[j, i];
                        min_index = j;
                    }
                    if (max < A[j, i])
                    {
                        max = A[j, i];
                        max_index = j;
                    }
                }
                A[min_index, i] = max;
                A[max_index, i] = min;
            }
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(A[i, j] + "|");
                }
                Console.WriteLine();
            }
        }
        public static void Matrix51(int M, int N)
        {
            int[,] A = new int[M, N];
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    A[i, j] = rnd.Next(10, 100);
                    Console.Write(A[i, j] + "|");
                }
                Console.WriteLine();
            }
            Console.WriteLine("________________");
            int min = A[0, 0];
            int min_index = 0;
            int max = min;
            int max_index = 0;
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (min > A[i, j])
                    {
                        min = A[i, j];
                        min_index = i;
                    }
                    if (max < A[i, j])
                    {
                        max = A[i, j];
                        max_index = i;
                    }
                }
            }
            Console.WriteLine($"minimum: {min}, index: {min_index}");
            Console.WriteLine($"maximum: {max}, index: {max_index}");
            Console.WriteLine("______________________");
            int[] array = new int[N];
            for (int i = 0; i < N; i++)
            {
                array[i] = A[min_index, i];
                A[min_index, i] = A[max_index, i];
                A[max_index, i] = array[i];
            }
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(A[i, j] + "|");
                }
                Console.WriteLine();
            }
        }
        public static void Matrix75(int M, int N)
        {
            int[,] A = new int[M, N];
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    A[i, j] = rnd.Next(10, 100);
                    Console.Write(A[i, j] + "|");
                }
                Console.WriteLine();
            }
            Console.WriteLine("________________");
            for (int x = 0; x < M; x++)
            {
                for (int y = 0; y < N; y++)
                {
                    if (x == 0)
                    {
                        if (A[x, y] > A[x, y - 1] && A[x, y] > A[x, y + 1] && A[x, y] > A[x + 1, y - 1] && A[x, y] > A[x + 1, y] && A[x, y] > A[x + 1, y + 1])
                            A[x, y] *= -1;
                    }
                    else if (x == M - 1)
                    {
                        if (A[x, y] > A[x, y - 1] && A[x, y] > A[x, y + 1] && A[x, y] > A[x - 1, y - 1] && A[x, y] > A[x - 1, y] && A[x, y] > A[x - 1, y + 1])
                            A[x, y] *= -1;
                    }
                    else if (y == 0)
                    {
                        if (A[x, y] > A[x - 1, y] && A[x, y] > A[x - 1, y + 1] && A[x, y] > A[x, y + 1] && A[x, y] > A[x + 1, y] && A[x, y] > A[x + 1, y + 1])
                            A[x, y] *= -1;
                    }

                }
            }
        }
        public static void Matrix76(int M, int N)
        {
            int[,] A = new int[M, N];
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    A[i, j] = rnd.Next(10, 100);
                    Console.Write(A[i, j] + "|");
                }
                Console.WriteLine();
            }
            Console.WriteLine("________________");
        }
        public static void Matrix80(int M)
        {
            int[,] A = new int[M, M];
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    A[i, j] = rnd.Next(10, 100);
                    if (j == i) Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(A[i, j] + "|");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine();
            }
            Console.WriteLine("________________");
            int sum = 0;
            for (int i = 0; i < M; i++)
            {
                sum += A[i, i];
            }
            Console.WriteLine(sum);
        }
        public static void Matrix81(int M)
        {
            int[,] A = new int[M, M];
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    A[i, j] = rnd.Next(10, 100);
                    if (j == M - 1 - i) Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(A[i, j] + "|");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine();
            }
            Console.WriteLine("________________");
            int sum = 0;
            for (int i = 0; i < M; i++)
            {
                sum += A[i, M - 1 - i];
            }
            Console.WriteLine(sum / M);
        }
        public static void Matrix82(int M)
        {
            int[,] A = new int[M, M];
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    A[i, j] = rnd.Next(10, 100);
                    if (j == i || j == M - 1 - i) Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(A[i, j] + "|");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine();
            }
            Console.WriteLine("________________");
            int sum = 0;
            for (int i = 0; i < M; i++)
            {
                if (M - 1 - i != i)
                    sum += A[i, i] + A[i, M - 1 - i];
                else
                    sum += A[i, i];
            }

            Console.WriteLine(sum);
        }
        public static void Matrix95(int M)
        {
            int[,] A = new int[M, M];
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    A[i, j] = rnd.Next(1, 10);
                    if (j == i || j == M - 1 - i) Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(A[i, j] + "|");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine();
            }
            Console.WriteLine("________________");
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    A[i, j] = 0;
                    A[i, M - 1 - j] = 0;
                }
            }
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write(A[i, j] + "|");
                }
                Console.WriteLine();
            }
        }
        public static void Matrix96(int M)
        {
            int[,] A = new int[M, M];
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    A[i, j] = rnd.Next(10, 100);
                    if (j == i || j == M - 1 - i) Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(A[i, j] + "|");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine();
            }
            Console.WriteLine("________________");
            for (int i = 0; i < M; i++)
            {
                for (int j = i + 1; j < M; j++)
                {
                    int number = A[i, j];
                    A[i, j] = A[j, i];
                    A[j, i] = number;
                }
            }
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write(A[i, j]);
                }
                Console.WriteLine();
            }
        }
        public static void Matrix97(int M)
        {
            int[,] A = new int[M, M];
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    A[i, j] = rnd.Next(10, 100);
                    if (j == M - 1 - i) Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(A[i, j] + "|");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine();
            }
            Console.WriteLine("________________");
            for (int i = 0; i < M / 2 + 1; i++)
            {
                for (int j = 0; j < M - 1 - i; j++)
                {
                    int number = A[i, j];
                    A[i, j] = A[M - 1 - j, M - i - 1];
                    A[M - 1 - j, M - i - 1] = number;
                }
            }
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (j == M - 1 - i) Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(A[i, j] + "|");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine();
            }
        }
        public static void Matrix98(int M)
        {
            int[,] A = new int[M, M];
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    A[i, j] = rnd.Next(10, 100);
                    if (j == M - 1 - i) Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(A[i, j] + "|");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine();
            }
            Console.WriteLine("________________");
            for (int i = 0; i <= M / 2; i++)
            {
                if (M % 2 == 1 && i == M / 2)
                    for (int j = 0; j < M / 2; j++)
                    {
                        int number = A[i, j];
                        A[i, j] = A[M - 1 - i, M - 1 - j];
                        A[M - 1 - i, M - 1 - j] = number;
                    }
                else
                    for (int j = 0; j < M; j++)
                    {
                        int number = A[i, j];
                        A[i, j] = A[M - 1 - i, M - 1 - j];
                        A[M - 1 - i, M - 1 - j] = number;
                    }
            }
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write(A[i, j] + "|");
                }
                Console.WriteLine();
            }
        }
    }
}
