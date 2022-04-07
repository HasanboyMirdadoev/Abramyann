using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abramyann
{
    class Case
    {
        public static string Task1(int a)
        {
            switch (a)
            {
                case 1:
                    return "Monday";
                case 2:
                    return "Tuesday";
                case 3:
                    return "Wednesday";
                case 4:
                    return "Thursday";
                case 5:
                    return "Friday";
                case 6:
                    return "Saturday";
                default:
                    return "Sunday";
            }
        }
        public static string Task2(int k)
        {
            switch (k)
            {
                case 1:
                    return "bad";
                case 2:
                    return "not bad";
                case 3:
                    return "normal";
                case 4:
                    return "fine";
                case 5:
                    return "great";
                default:
                    return "error";
            }
        }
        public static string Task3(int a)
        {
            switch (a)
            {
                case 1:
                case 2:
                case 12: return "Winter";
                case 3:
                case 4:
                case 5: return "Spring";
                case 6:
                case 7:
                case 8: return "Summer";
                case 9:
                case 10:
                case 11: return "Autumn";
                default: return "";
            }
        }
        public static int Task4(int a)
        {
            switch (a)
            {
                case 1:
                case 3:
                case 7:
                case 8:
                case 10:
                case 12: return 31;
                case 2: return 28;
                default: return 30;
            }
        }
        public static double Task5(int n, int a, int b)
        {
            switch (n)
            {
                case 1: return a + b;
                case 2: return a - b;
                case 3: return a * b;
                default: return a / b;
            }
        }
        public static double Task6(int n, int a)
        {
            switch (n)
            {
                case 1: return a / 100;
                case 2: return a * 1000;
                case 3: return a;
                case 4: return a / 1000;
                default: return a / 100;
            }
        }
        public static double Task7(int n, int a)
        {
            switch (n)
            {
                case 1: return a;
                case 2: return a / 1000000;
                case 3: return a/1000;
                case 4: return a * 1000;
                default: return a * 100;
            }
        }
    }
}
