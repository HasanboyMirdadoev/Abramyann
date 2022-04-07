using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abramyann
{
    class If
    {
        public static int Task1(int a)
        {
            if (a >= 0) return a + 1;
            else return a;
        }
        public static int Task2(int a)
        {
            if (a >= 0) return a + 1;
            else return a - 2;
        }
        public static int Task3(int a)
        {
            if (a >= 0) return a + 1;
            else if (a == 0) return 10;
            else return a - 2;
        }
        public static int Task4(int a, int b, int c)
        {
            int counter = 0;
            if (a > 0) counter++;
            if (b > 0) counter++;
            if (c > 0) counter++;
            return counter;
        }
        public static string Task5(int a, int b, int c)
        {
            int counter = 0;
            if (a > 0) counter++;
            if (b > 0) counter++;
            if (c > 0) counter++;
            return $"number of positives: {counter}, number of negatives: {3 - counter}";
        }
        public static int Task6(int a, int b)
        {
            if (a > b) return a;
            else return b;
        }
        public static string Task9(int a, int b)
        {
            if (a > b)
            {
                int _b = b;
                b = a;
                a = _b;
                return $"A = {a}, B = {b}";
            }
            else return $"A = {a}, B = {b}";
        }
        public static string Task10(int a, int b)
        {
            if (a != b)
            {
                a += a + b;
                b += a + b;
                return $"A = {a}, B = {b}";
            }
            else
            {
                a = 0;
                b = 0;
                return $"A = {a}, B = {b}";
            }
        }
        public static string Task11(int a, int b)
        {
            if (a <= b) { a = b; return $"A = {a}, B = {b}"; }
            else if (a >= b) { b = a; return $"A = {a}, B = {b}"; }
            else { a = 0; b = 0; return $"A = {a}, B = {b}"; }
        }
        public static int Task12(int a, int b, int c)
        {
            if (c < a && c < b) return c;
            else if (a > b && c > b) return b;
            else return a;
        }
        public static int Task13(int a, int b, int c)
        {
            if (a > b && a < c || a < b && a > c) return a;
            else if (b < a && b > c || b > a && b < c) return b;
            else return c;
        }
        public static string Task14(int a, int b, int c)
        {
            string number;
            if (c < a && c < b) number = $"Least number: {c}";
            else if (a > b && c > b) number = $"Least number: {b}";
            else return number = $"Least number: {a}";

            if (c > a && c > b) number += $"Greatest number: {c}";
            else if (a < b && c < b) number += $"Greatest number: {b}";
            else return number += $"Greatest number: {a}";

            return number;
        }
        public static int Task15(int a, int b, int c)
        {
            if (a < b && a < c) return b + c;
            else if (b < a && b < c) return a + c;
            else return a + b;
        }
        public static string Task16(int a, int b, int c)
        {
            if (a < b && b < c) { a = a * 2; b = b * 2; c = c * 2; return $"A: {a}, B: {b}, C:{c}"; }
            else { a = -1 * a; b = -1 * b; c = -1 * c; return $"A: {a}, B: {b}, C:{c}"; }
        }
        public static string Task17(int a, int b, int c)
        {
            if (a < b && b < c || a > b && b > c) { a = a * 2; b = b * 2; c = c * 2; return $"A: {a}, B: {b}, C:{c}"; }
            else { a = -1 * a; b = -1 * b; c = -1 * c; return $"A: {a}, B: {b}, C:{c}"; }
        }
        public static int Task18(int a, int b, int c)
        {
            if (a == b) return 3;
            else if (a == c) return 2;
            else return 1;
        }
        public static int Task19(int a, int b, int c, int d)
        {
            if (a == b && b == c) return 4;
            else if (a == b && b == d) return 3;
            else if (a == c && c == d) return 2;
            else return 1;
        }
        public static int Task20(int a, int b, int c)
        {
            if (Math.Abs(b - a) > Math.Abs(c - a)) return a;
            else return b;
        }
        public static int Task21(int x, int y)
        {
            if (x == 0 && y == 0) return 0;
            else if (x == 0 || y == 0) return 1;
            else return 3;
        }
        public static int Task22(int x, int y)
        {
            if (x > 0 && y > 0) return 1;
            else if (x < 0 && y > 0) return 2;
            else if (x < 0 && y < 0) return 3;
            else return 4;
        }
        public static string Task23(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            int x4;
            int y4;
            if (x1 == x2) x4 = x3;
            else if (x1 == x3) x4 = x2;
            else x4 = x1;

            if (y1 == y2) y4 = y3;
            else if (y1 == y3) y4 = y2;
            else y4 = y1;

            return $"x: {x4}, y: {y4}";
        }
        public static double Task24(int x)
        {
            if (x > 0) return Math.Sin(x);
            else return 6 - x;
        }
        public static double Task25(double x)
        {
            if (x < -2 || x > 2) return 2 * x;
            else return -3 * x;
        }
        public static double Task26(double x)
        {
            if (x <= 0) return -x;
            else if (x > 0 && x < 0) return x * x;
            else if (x >= 2) return 4;
            else return 0;
        }
        public static double Task27(double x)
        {
            if (x < 0) return 0;
            else if (x >= 0 && x % 2 == 0) return 1;
            else if (x > 0 && x % 2 == 1) return -1;
            else return 45674567;
        }
        public static int Task28(int a)
        {
            if (a % 4 == 0)
            {
                if (a % 100 == 0 && a % 400 != 0) return 365;
                else return 366;
            }
            else return 365;
        }
        public static string Task29(int a)
        {
            if (a < 0)
            {
                if (a % 2 == 0) return "negative even number";
                else return "negative odd number";
            }
            else if (a > 0)
            {
                if (a % 2 == 0) return "positive even number";
                else return "positve odd number";
            }
            else return "zero";
        }
        public static string Task30(int a)
        {
            string returnAs;
            if (a < 10) returnAs = "one digit ";
            else if (a < 100) returnAs = "two digit ";
            else returnAs = "three digit";

            if (a % 2 == 0) returnAs += "even number";
            else returnAs += "odd number";

            return returnAs;
        }
    }
}
