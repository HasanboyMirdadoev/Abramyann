using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abramyann
{
    class Proc
    {
        public static double Proc1(double A)
        {
            return Math.Pow(A, 3);
        }
        public static void Proc2(double A, out double B, out double C, out double D)
        {
            B = Math.Pow(A, 2);
            C = Math.Pow(A, 3);
            D = Math.Pow(A, 4);
        }
        public static void Proc3(double X, double Y, out double AMean, out double GMean)
        {
            AMean = (X + Y / 2);
            GMean = Math.Sqrt(X * Y);
        }
        public static void Proc4(double A, out double P, out double S)
        {
            P = 3 * A;
            S = A * A * Math.Sqrt(3) / 4;
        }
        public static void Proc5(double x1, double y1, double x2, double y2, out double P, out double S)
        {
            double l1 = Math.Abs(x1 - x2);
            double l2 = Math.Abs(y1 - y2);
            P = (l1 + l2) * 2;
            S = l1 * l2;
        }
        public static void Proc6(int K, out int C, out int S)
        {
            char[] array = K.ToString().ToCharArray();
            C = array.Length;
            int sum = 0;
            foreach (var number in array)
            {
                sum += Convert.ToInt32(number.ToString());
            }
            S = sum;
        }
        public static void Proc7(ref int K)
        {
            char[] array = K.ToString().ToCharArray();
            string reverse = "";
            for (int i = array.Length - 1; i >= 0; i--)
            {
                reverse += array[i];
            }
            K = Convert.ToInt32(reverse);
        }
        public static void Proc8(ref int K, int D)
        {
            K *= 10;
            K += D;
        }
        public static void Proc9(ref int K, int D)
        {
            int length = K.ToString().ToCharArray().Length;
            K = Convert.ToInt32(Math.Pow(10, length) * D + K);
        }
        public static void Proc10(ref int X, ref int Y)
        {
            int a = X;
            X = Y;
            Y = a;
        }
        public static void Proc11(ref int X, ref int Y)
        {
            if (X > Y)
            {
                int a = X;
                X = Y;
                Y = a;
            }
        }
        public static void Proc12(ref int A, ref int B, ref int C)
        {
            if (C < B) { int c = C; C = B; B = c; }
            if (A > B) { int a = A; A = B; B = a; }
            if (C < B) { int c = C; C = B; B = c; }
        }
        public static void Proc13(ref int A, ref int B, ref int C)
        {
            if (A < B) { int c = A; A = B; B = c; }
            if (C > B) { int a = C; C = B; B = a; }
            if (A < B) { int c = A; A = B; B = c; }
        }
        public static void Proc14(ref int A, ref int B, ref int C)
        {
            int b = B;
            B = A;
            A = C;
            C = b;
        }
        public static void Proc15(ref int A, ref int B, ref int C)
        {
            int c = C;
            C = A;
            A = B;
            B = C;
        }
        public static int Proc16(int X)
        {
            if (X < 0) return -1;
            else if (X > 0) return 1;
            else return X;
        }
        public static int Proc17(int A, int B, int C)
        {
            double D = B * B - 4 * A * C;
            if (D > 0) return 2;
            else if (D == 0) return 1;
            else return 0;
        }
        public static double Proc18(int R)
        {
            double S = 3.14 * R * R;
            return S;
        }
        public static double Proc20(double a, double h)
        {
            double b = Math.Sqrt((a / 2) * (a / 2) + h * h);
            return 2 * b + a;
        }
        public static int Proc21(int A, int B)
        {
            int sum = 0;
            for (int i = A; i <= B; i++)
            {
                sum += i;
            }
            return sum;
        }
        public static int Proc22(int A, int B, int Op)
        {
            if (Op == 1) return A - B;
            else if (Op == 2) return A * B;
            else if (Op == 3) return A / B;
            else return A + B;
        }
        public static void Proc50(int T, out int M, out int H, out int S)
        {
            H = T / 3600;
            int r = T % 3600;
            M = r / 60;
            S = r % 60;
        }
        public static void Proc51(ref int H, ref int M, ref int S, int T)
        {
            S += T;
            if (S > 60)
            {
                S = S % 60;
                int r = S / 60;
                M += r;
                if (M > 60)
                {
                    M = M % 60;
                    H += M / 60;
                }
            }
        }
        public static bool Proc52(int Y)
        {
            if (Y / 4 == 0 && Y / 100 != 0 && Y / 400 == 0)
                return true;
            else return false;
        }
        public static int Proc53(int M, int Y)
        {
            switch (M)
            {
                case 1:
                    return 31;
                case 2:
                    if (Proc52(Y))
                        return 29;
                    else return 28;
                case 3:
                    return 31;
                case 4:
                    return 30;
                case 5:
                    return 31;
                case 6:
                    return 30;
                case 7:
                    return 31;
                case 8:
                    return 31;
                case 9:
                    return 31;
                case 10:
                    return 30;
                case 11:
                    return 31;
                case 12:
                    return 31;
                default:
                    throw new IndexOutOfRangeException();
            }
        }
        public static void Proc54(ref int D, ref int M, ref int Y)
        {
            D += 1;
            if (Proc53(M, Y) < D)
            {
                D = 1;
                M = M + 1;
                if (M > 12)
                {
                    M = 1;
                    Y += 1;
                }
            }
        }
    }
}
