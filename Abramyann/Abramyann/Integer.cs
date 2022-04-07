using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abramyann
{
    class Integer
    {
        public static int Task1(int l)
        {
            int a = l / 100;
            return a;
        }
        public static int Task2(int l)
        {
            int a = l / 1000;
            return a;
        }
        public static int Task3(int bytes)
        {
            int kilobytes = bytes / 1024;
            return kilobytes;
        }
        public static int Task4(int a, int b)
        {
            int numberOfBs = a / b;
            return numberOfBs;
        }
        public static int Task5(int a, int b)
        {
            int remainder = a % b;
            return remainder;
        }
        public static string Task6(int a)
        {
            int fNumber = a / 10;
            int SNumber = a % 10;
            return $" first number: {fNumber}, second numer: {SNumber}";
        }
        public static string Task7(int a)
        {
            int fNumber = a / 10;
            int SNumber = a % 10;
            int mult = fNumber * SNumber;
            int add = fNumber + SNumber;
            return $" Addition: {add}, Multiplycation: {mult}";
        }
        public static int Task8(int a)
        {
            int fNumber = a / 10;
            int SNumber = a % 10;
            int newNumber = SNumber * 10 + fNumber;
            return newNumber;
        }
        public static int Task9(int a)
        {
            int firstNumber = a / 100;
            return firstNumber;
        }
        public static string Task10(int a)
        {
            int twoDigitNumber = a % 100;
            int lastNumber = twoDigitNumber % 10;
            int secondNumber = twoDigitNumber / 10;
            return $"last number: {lastNumber}, second number: {secondNumber}";
        }
        public static string Task11(int a)
        {
            int firstNumber = a / 100;
            int twoDigitNumber = firstNumber % 100;
            int secondNumber = twoDigitNumber / 10;
            int lastNumber = twoDigitNumber % 10;
            int addition = firstNumber + secondNumber + lastNumber;
            int multiplycation = firstNumber * secondNumber * lastNumber;
            return $"addition: {addition}, multiplycation: {multiplycation}";
        }
        public static int Task12(int a)
        {
            int firstNumber = a / 100;
            int twoDigitNumber = firstNumber % 100;
            int secondNumber = twoDigitNumber / 10;
            int lastNumber = twoDigitNumber % 10;
            int reverse = lastNumber * 100 + secondNumber * 10 + firstNumber;
            return reverse;
        }
        public static int Task13(int a)
        {
            int firstNumber = a / 100;
            int twoDigitNumber = firstNumber % 100;
            int secondNumber = twoDigitNumber / 10;
            int lastNumber = twoDigitNumber % 10;
            int newNumber = secondNumber * 100 + lastNumber * 10 + firstNumber;
            return newNumber;
        }
        public static int Task14(int a)
        {
            int firstNumber = a / 100;
            int twoDigitNumber = firstNumber % 100;
            int secondNumber = twoDigitNumber / 10;
            int lastNumber = twoDigitNumber % 10;
            int newNumber = lastNumber * 100 + firstNumber * 10 + secondNumber;
            return newNumber;
        }
        public static int Task15(int a)
        {
            int firstNumber = a / 100;
            int twoDigitNumber = firstNumber % 100;
            int secondNumber = twoDigitNumber / 10;
            int lastNumber = twoDigitNumber % 10;
            int newNumber = secondNumber * 100 + firstNumber * 10 + lastNumber;
            return newNumber;
        }
        public static int Task16(int a)
        {
            int firstNumber = a / 100;
            int twoDigitNumber = firstNumber % 100;
            int secondNumber = twoDigitNumber / 10;
            int lastNumber = twoDigitNumber % 10;
            int newNumber = firstNumber * 100 + lastNumber * 10 + secondNumber;
            return newNumber;
        }
        public static int Task17(int a)
        {
            int threeDigitumber = a % 1000;
            int secondNumber = threeDigitumber / 100;
            return secondNumber;
        }
        public static int Task18(int a)
        {
            int firstNumber = a / 1000;
            return firstNumber;
        }
        public static int Task19(int a)
        {
            int minutes = a / 60;
            return minutes;
        }
        public static int Task20(int a)
        {
            int hours = a / 3600;
            return hours;
        }
        public static int Task21(int a)
        {
            int seconds = a % 60;
            return seconds;                
        }
        public static int Task22(int a)
        {
            int seconds = a % 3600;
            return seconds;
        }
        public static int Task23(int a)
        {
            int seconds = a % 3600;
            int minutes = seconds / 60;
            return minutes;
        }
        public static int Task24(int k)
        {
            int rem = k % 7;
            return rem;
        }
        public static int Task25(int k)
        {
            int rem = k % 7;
            int numberOfDay = (rem + 3) % 7;
            return numberOfDay;
        }
        public static int Task26(int k)
        {
            int rem = k % 7;
            return rem + 1;
        }
        public static int Task27(int k)
        {
            int rem = k % 7;
            int numberOfDay = (rem + 5) % 7;
            return numberOfDay;
        }
        public static int Task28(int k, int n)
        {
            int remainder = k % 7;
            int numberOfDay = (remainder + n - 1) % 7;
            return numberOfDay;
        }
        public static int Task29(int a, int b, int c)
        {
            int Sab = a * b;
            int Sc = c * c;
            int com = Sab / Sc;
            int rem = Sab % Sc;
            return com;
        }
        public static int Task30(int y)
        {
            int cen = y / 100 + 1;
            return cen;
        }
    }
}
