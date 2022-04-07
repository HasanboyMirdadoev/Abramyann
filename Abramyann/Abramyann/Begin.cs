using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abramyann
{
    class Begin
    {
        public static int Task1(int a)
        {
            int P = 4 * a;
            return P;
        }
        public static int Task2(int a)
        {
            int S = a * a;
            return S;
        }
        public static string Task3(int a, int b)
        {
            int P = (a + b) * 2;
            int S = a * b;
            return $"Perimetr: {P}, Area: {S}";
        }
        public static double Task4(int d)
        {
            double L = Math.PI * d;
            return L;
        }
        public static string Task5(int a)
        {
            int V = a * a * a;
            int S = 6 * a * a;
            return $"V = {V}, S = {S}";
        }
        public static string Task6(int a, int b, int c)
        {
            int V = a * b * c;
            int S = 2 * (a * b + b * c + c * a);
            return $"V = {V}, S = {S}";
        }
        public static string Task7(int R)
        {
            double S = Math.PI * R * R;
            double L = 2 * Math.PI * R;
            return $"S = {S}, L = {L}";
        }
        public static double Task8(int a, int b)
        {
            double avarage = (a + b) / 2;
            return avarage;
        }
        public static double Task9(int a, int b)
        {
            double geometricAv = Math.Sqrt(a * b);
            return geometricAv;
        }
        public static string Task10(int c, int d)
        {
            int a = c * c;
            int b = d * d;
            int addition = a + b;
            int substraction = a - b;
            int multiplication = a * b;
            double division = a / b;
            return $"addition: {addition}, substraction: {substraction}, multiplication: {multiplication}, division: {division}";
        }
        public static string Task11(int c, int d)
        {
            double a = Math.Sqrt(c * c);
            double b = Math.Sqrt(d * d);
            double addition = a + b;
            double substraction = a - b;
            double multiplication = a * b;
            double division = a / b;
            return $"addition: {addition}, substraction: {substraction}, multiplication: {multiplication}, division: {division}";
        }
        public static string Task12(int a, int b)
        {
            double c = Math.Sqrt(a * a + b * b);
            double P = a + b + c;
            return $"c = {c}, P = {P}";
        }
        public static double Task13(int r1, int r2)
        {
            double S1 = Math.PI * r1 * r1;
            double S2 = Math.PI * r2 * r2;
            double S3 = S1 - S2;
            return S3;
        }
        public static double Task14(double l)
        {
            double R = l / (2 * Math.PI);
            double S = Math.PI * R * R;
            return S;
        }
        public static double Task15(double S)
        {
            double R = Math.Sqrt(S / Math.PI);
            double D = 2 * R;
            double L = D * Math.PI;
            return L;
        }
        public static double Task16(double x1, double x2)
        {
            double l = Math.Abs(x2 - x1);
            return l;
        }
        public static double Task17(double a, double b, double c)
        {
            double lAC = Math.Abs(c - a);
            double lBC = Math.Abs(c - b);
            double LAC_BC = lAC + lBC;
            return LAC_BC;
        }
        public static double Task18(double a, double b, double c)
        {
            double lAC = Math.Abs(c - a);
            double lBC = Math.Abs(b - c);
            double multi = lAC * lBC;
            return multi;
        }
        public static string Task19(double x1, double y1, double x2, double y2)
        {
            double a = Math.Abs(x2 - x1);
            double b = Math.Abs(y1 - y2);
            double P = (a + b) * 2;
            double S = a * b;
            return $"P = {P}, S = {S}";
        }
        public static double Task20(double x1, double y1, double x2, double y2)
        {
            double l = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return l;
        }
        public static string Task21(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            double a = Task20(x1, y1, x2, y2);
            double b = Task20(x1, y1, x3, y3);
            double c = Task20(x2, y2, x3, y3);
            double p = (a + b + c) / 2;
            double P = a + b + c;
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return $" P = {P}, S = {S}";
        }
        public static string Task22(double a, double b)
        {
            double _b = b;
            b = a;
            a = _b;
            return $" A = {a}, B = {b}";
        }
        public static string Task23(int a, int b, int c)
        {
            int _b = b;
            b = a;
            int _c = c;
            c = _b;
            a = _c;
            return $"A = {a}, B = {b}, C = {c}";
        }
        public static string Task24(int a, int b, int c)
        {
            int _a = a;
            a = c;
            c = b;
            b = _a;
            return $"A = {a}, B = {b}, C = {c}";
        }
        public static double Task25(double x)
        {
            double y = 3 * Math.Pow(x, 6) - 6 * Math.Pow(x, 2) - 7;
            return y;
        }
        public static double Task26(double x)
        {
            double y = 4 * Math.Pow(x - 3, 6) - 7 * Math.Pow(x - 3, 3) + 2;
            return y;
        }
        public static string Task27(double A)
        {
            double A2 = A * A;
            double A4 = A2 * A2;
            double A8 = A4 * A4;
            return $"A2 = {A2}, A4 = {A4} A8 = {A8}";
        }
        public static double Task28(double A)
        {
            double A2 = A * A;
            double A3 = A2 * A;
            double A5 = A2 * A3;
            double A10 = A2 * A3 * A5;
            double A15 = A10 * A5;
            return A15;
        }
        public static double Task29(double a)
        {
            double inDegrees = a / 180;
            double meridiana = inDegrees * 3.14;
            return meridiana;
        }
        public static double Task30(double a)
        {
            double b = a / 3.14;
            double inDegrees = b * 180;
            return inDegrees;
        }
        public static double Task31(double Tf)
        {
            double Tc = (Tf - 32) * 5 / 9;
            return Tc;
        }
        public static double Task32(double Tc)
        {
            double Tf = Tc / (5 / 9) + 32;
            return Tf;
        }
        public static double Task33(double x, double a, double y)
        {
            double kg1 = a / x;
            double Ykg = (a / x) * y;
            return Ykg;
        }
        public static double Task34(double x, double a, double y, double b)
        {
            double KgIris = b / y;
            double KgShoko = a / x;
            double compareness = KgShoko / KgIris;
            return compareness;
        }
        public static double Task35(double t1, double t2, double v, double u)
        {
            double S = t1 * (v - u) + t2 * v;
            return S;
        }
        public static double Task36(double v1, double v2, double t, double firstS)
        {
            double S = (v1 + v2) * t + firstS;
            return S;
        }
        public static double Task37(double v1, double v2, double t, double firstS)
        {
            double S = Math.Abs(firstS - (v1 + v2) * t);
            return S;
        }
        public static double Task38(double a, double b)
        {
            double x = (-b) / a;
            return x;
        }
        public static string Task39(double a, double b, double c)
        {
            double d = b * b - 4 * a * c;
            double x1 = (-b - Math.Sqrt(d)) / (2 * a);
            double x2 = (-b + Math.Sqrt(d)) / (2 * a);
            return $"x1 = {x1}, x2 = {x2}";
        }
        public static string Task40(double a1, double b1, double c1, double a2, double b2, double c2)
        {
            double d = a1 * b2 - a2 * b1;
            double x = (c1 * b2 - c2 * b1) / d;
            double y = (a1 * c2 - c1 * a2) / d;
            return $"x = {x} y = {y}";
        }
    }
}
