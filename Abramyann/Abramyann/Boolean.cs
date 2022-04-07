using System;

namespace Abramyann
{
    class Boolean
    {
        public static bool Task1(int a)
        {
            bool isPositive;
            if (a < 0)
            {
                isPositive = false;
            }
            else
            {
                isPositive = true;
            }
            return isPositive;
        }
        public static bool Task2(int a)
        {
            bool isOdd;
            if (a % 2 == 0)
            {
                isOdd = false;
            }
            else
            {
                isOdd = true;
            }
            return isOdd;
        }
        public static bool Task3(int a)
        {
            bool isEven;
            if (a % 2 == 0)
            {
                isEven = true;
            }
            else
            {
                isEven = false;
            }
            return isEven;
        }
        public static bool Task4(int a, int b)
        {
            bool isTrue;
            if (a > 2 && b <= 3)
            {
                isTrue = true;
            }
            else
            {
                isTrue = false;
            }
            return isTrue;
        }
        public static bool Task5(int a, int b)
        {
            bool isTrue;
            if (a >= 0 && b < -2)
            {
                isTrue = true;
            }
            else
            {
                isTrue = false;
            }
            return isTrue;
        }
        public static bool Task6(int a, int b, int c)
        {
            bool isTrue;
            if (a < b && b < c)
            {
                isTrue = true;
            }
            else
            {
                isTrue = false;
            }
            return isTrue;
        }
        public static bool Task7(int a, int b, int c)
        {
            bool isTrue;
            if (a < b && b < c)
            {
                isTrue = true;
            }
            else
            {
                isTrue = false;
            }
            return isTrue;
        }
        public static bool Task8(int a, int b)
        {
            if (a % 2 == 1 && b % 2 == 1)
            {
                return true;
            }
            else return false;
        }
        public static bool Task9(int a, int b)
        {
            if (a % 2 == 1 || b % 2 == 1)
            {
                return true;
            }
            else return false;
        }
        public static bool Task10(int a, int b)
        {
            if (a % 2 == 1 && b % 2 == 0 || a % 2 == 0 && b % 2 == 1)
            {
                return true;
            }
            else return false;
        }
        public static bool Task12(int a, int b, int c)
        {
            if (a > 0 && b > 0 && c > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool Task13(int a, int b, int c)
        {
            if (a > 0 || b > 0 || c > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool Task14(int a, int b, int c)
        {
            if (a > 0 && b < 0 && c < 0 || a < 0 && b > 0 && c < 0 || a < 0 && b < 0 && c > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool Task15(int a, int b, int c)
        {
            if (a > 0 && b > 0 && c < 0 || a < 0 && b > 0 && c > 0 || a > 0 && b < 0 && c > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool Task16(int a)
        {
            if (a > 9 && a < 100 && a % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool Task17(int a)
        {
            if (a > 99 && a < 1000 && a % 2 == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool Task18(int a, int b, int c)
        {
            if (a == b || b == c || a == c)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool Task19(int a, int b, int c)
        {
            if (a == -b || b == -c || a == -c)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool Task20(int a)
        {
            int first = a / 100;
            int others = a % 100;
            int second = others / 10;
            int third = others % 10;
            if (first != second && second != third && first != third)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool Task21(int a)
        {
            int first = a / 100;
            int others = a % 100;
            int second = others / 10;
            int third = others % 10;
            if (first < second && second < third)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool Task22(int a)
        {
            int first = a / 100;
            int others = a % 100;
            int second = others / 10;
            int third = others % 10;
            if (first < second && second < third || first > second && second > third)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool Task23(int a)
        {
            int first = a / 1000;
            int others = a % 1000;
            int second = others / 100;
            int others2 = others % 100;
            int third = others2 / 10;
            int fourth = others2 % 10;
            if (first == fourth && second == third)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool Task24(int a, int b, int c)
        {
            double d = Math.Pow(b, 2) - 4 * a * c;
            if (d > 0)
            {
                return true;
            }
            else return false;
        }
        public static bool Task25(int x, int y)
        {
            if (x > 0 && y > 0)
            {
                return true;
            }
            else return false;
        }
        public static bool Task26(int x, int y)
        {
            if (x < 0 && y < 0)
            {
                return true;
            }
            else return false;
        }
        public static bool Task27(int x, int y)
        {
            if (x > 0 && y > 0 || x > 0 && y < 0)
            {
                return true;
            }
            else return false;
        }
        public static bool Task28(int x, int y)
        {
            if (x < 0 && y > 0 || x > 0 && y < 0)
            {
                return true;
            }
            else return false;
        }
        public static bool Task29(int x, int y, int x1, int y1, int x2, int y2)
        {
            if (x > x1 && x < x2 && y > y2 && y < y1) return true;
            else return false;
        }
        public static bool Task30(int a, int b, int c)
        {
            if (a == b && b == c) return true;
            else return false;
        }
        public static bool Task31(int a, int b, int c)
        {
            if (a == b && b != c) return true;
            else return false;
        }
        public static bool Task32(int a, int b, int c)
        {
            if (a * a + b * b == c * c) return true;
            else return false;
        }
        public static bool Task33(int a, int b, int c)
        {
            if (a + b >= c && a + c >= b && b + c >= a) return true;
            else return false;
        }
        public static bool Task34(int x, int y)
        {
            if (y % 2 == 1 && x % 2 == 0 || y % 2 == 0 && x % 2 == 1) return true;
            else return false;
        }
        public static bool Task35(int x, int y, int x1, int y1)
        {
            if (y % 2 == 1 && x % 2 == 0 && y1 % 2 == 1 && x1 % 2 == 0
                || y % 2 == 0 && x % 2 == 1 && y1 % 2 == 0 && x1 % 2 == 1
                || y % 2 == 1 && x % 2 == 0 && y1 % 2 == 0 && x1 % 2 == 1
                || y % 2 == 0 && x % 2 == 1 && y1 % 2 == 1 && x1 % 2 == 0
                || y % 2 == 1 && x % 2 == 1 && y1 % 2 == 1 && x1 % 2 == 1
                || y % 2 == 1 && x % 2 == 1 && y1 % 2 == 0 && x1 % 2 == 0
                || y % 2 == 0 && x % 2 == 0 && y1 % 2 == 1 && x1 % 2 == 1
                || y % 2 == 0 && x % 2 == 0 && y1 % 2 == 0 && x1 % 2 == 0)
                return true;
            else return false;
        }
        public static bool Task36(int x, int y, int x1, int y1)
        {
            int lx = Math.Abs(x - x1);
            int ly = Math.Abs(y - y1);
            if (lx == 0 && ly != 0 || ly == 0 && lx != 0) return true;
            else return false;
        }
        public static bool Task37(int x, int y, int x1, int y1)
        {
            int lx = Math.Abs(x - x1);
            int ly = Math.Abs(y - y1);
            if (lx == 1 && ly == 0 || lx == 0 && ly == 0 || lx == 1 && ly == 1) return true;
            else return false;
        }
        public static bool Task38(int x, int y, int x1, int y1)
        {
            int lx = Math.Abs(x - x1);
            int ly = Math.Abs(y - y1);
            if (lx == ly) return true;
            else return false;
        }
        public static bool Task39(int x, int y, int x1, int y1)
        {
            int lx = Math.Abs(x - x1);
            int ly = Math.Abs(y - y1);
            if (lx == 0 && ly != 0 || ly == 0 && lx != 0 || lx == ly) return true;
            else return false;
        }
        public static bool Task40(int x, int y, int x1, int y1)
        {
            int lx = Math.Abs(x - x1);
            int ly = Math.Abs(y - y1);
            if (lx == 2 && ly == 1 || lx == 1 && ly == 2) return true;
            else return false;
        }
    }
}
