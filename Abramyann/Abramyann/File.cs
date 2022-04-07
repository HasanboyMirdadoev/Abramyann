using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Abramyann
{
    class FileTasks
    {
        static string path = $"{Directory.GetCurrentDirectory()}\\setting.txt";
        public static bool File1(string S)
        {
            try
            {
                File.Create(S);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static void File2(int N)
        {
            StreamWriter stream = File.CreateText(path);
            for (int i = 1; i <= N; i++)
            {
                stream.WriteLine((i * 2).ToString());
            }
            stream.Close();
        }
        public static void File3(int A, int D)
        {
            StreamWriter stream = File.CreateText(path);
            int member = A;
            for (int i = 0; i < 10; i++)
            {
                stream.WriteLine(member);
                member += D;
            }
            stream.Close();
        }
        public static void File5()
        {
            StreamReader stream = File.OpenText(path);
            int count = stream.ReadToEnd().ToCharArray().Length;
            Console.WriteLine(count);
        }
        public static void File6(int K)
        {
            try
            {
                StreamReader stream = File.OpenText(path);
                char item = stream.ReadToEnd().ToCharArray()[K];
                Console.WriteLine(item);
                stream.Close();
            }
            catch (Exception)
            {
                Console.WriteLine(-1);
            }
        }
        public static void File7()
        {
            StreamReader stream = File.OpenText(path);
            char[] text = stream.ReadToEnd().ToCharArray();
            Console.WriteLine(text[0]);
            Console.WriteLine(text[1]);
            Console.WriteLine(text[text.Length - 2]);
            Console.WriteLine(text[text.Length - 1]);
        }
        public static void File8(string path2)
        {
            StreamReader read = File.OpenText(path);
            char[] red_text = read.ReadToEnd().ToCharArray();
            StreamWriter write = File.CreateText(path2);
            write.Write(red_text[0]);
            write.Write(red_text[red_text.Length - 1]);
            read.Close();
            write.Close();
        }
        public static void File9(string path2)
        {
            if (File.Exists(path2))
            {
                StreamReader read = File.OpenText(path2);
                char[] text = read.ReadToEnd().ToCharArray();
                StreamWriter write = File.CreateText(path);
                write.Write(text[text.Length - 1]);
                write.Write(text[0]);
                write.Close();
                read.Close();
            }
            else
            {
                StreamReader read = File.OpenText(path);
                char[] text = read.ReadToEnd().ToCharArray();
                StreamWriter write = File.CreateText(path2);
                write.Write(text[text.Length - 1]);
                write.Write(text[0]);
                write.Close();
                read.Close();
            }
        }
        public static void File10(string path2)
        {
            StreamReader read = File.OpenText(path);
            char[] text = read.ReadToEnd().ToCharArray();
            StreamWriter write = File.CreateText(path2);
            for (int i = text.Length - 1; i >= 0; i--)
            {
                write.Write(text[i]);
            }
            read.Close();
            write.Close();
        }
        public static void File11(string path2, string path3)
        {
            StreamReader read = File.OpenText(path);
            char[] text = read.ReadToEnd().ToCharArray();
            StreamWriter file1 = File.CreateText(path2);
            StreamWriter file2 = File.CreateText(path3);
            for (int i = 1; i < text.Length; i += 2)
                file1.Write(text[i]);
            for (int i = 0; i < text.Length; i += 2)
                file2.Write(text[i]);
            file1.Close();
            file2.Close();
            read.Close();
        }
        public static void File12(string path2, string path3)
        {
            StreamReader read = File.OpenText(path);
            char[] text = read.ReadToEnd().ToCharArray();
            StreamWriter file1 = File.CreateText(path2);
            StreamWriter file2 = File.CreateText(path3);
            foreach (var item in text)
            {
                if (Convert.ToInt32(item) % 2 == 0)
                    file1.Write(item);
                else file2.Write(item);
            }
            read.Close();
            file1.Close();
            file2.Close();
        }
        public static void File13(string path2, string path3)
        {
            StreamReader read = File.OpenText(path);
            char[] text = read.ReadToEnd().ToCharArray();
            StreamWriter file1 = File.CreateText(path2);
            StreamWriter file2 = File.CreateText(path3);
            for (int i = text.Length - 1; i >= 0; i--)
            {
                if (Convert.ToInt32(text[i]) >= 0)
                    file1.Write(text[i]);
                else file2.Write(text[i]);
            }
            read.Close();
            file1.Close();
            file2.Close();
        }
        public static void File14()
        {
            StreamReader read = File.OpenText(path);
            char[] text = read.ReadToEnd().ToCharArray();
            int length = text.Length;
            int sum = 0;
            foreach (var item in text)
            {
                sum += Convert.ToInt32(item.ToString());
            }
            double avarage = sum / length;
            Console.WriteLine(avarage);
            read.Close();
        }
        public static void File15()
        {
            StreamReader read = File.OpenText(path);
            char[] text = read.ReadToEnd().ToCharArray();
            int sum = 0;
            for (int i = 0; i < text.Length; i += 2)
            {
                sum += Convert.ToInt32(text[i].ToString());
            }
            Console.WriteLine(sum);
            read.Close();
        }
        public static void File16()
        {
            StreamReader read = File.OpenText(path);
            char[] text = read.ReadToEnd().ToCharArray();
            int lastnumber = Convert.ToInt32(text[0].ToString());
            int count = 1;

            for (int i = 1; i < text.Length; i++)
                if (Convert.ToInt32(text[i].ToString()) != lastnumber)
                {
                    lastnumber = Convert.ToInt32(text[i].ToString());
                    count++;
                }
            Console.WriteLine(count);
            read.Close();
        }
        public static void File17(string path2)
        {
            StreamReader read = File.OpenText(path);
            char[] text = read.ReadToEnd().ToCharArray();
            StreamWriter file = File.CreateText(path2);
            int lastnumber = Convert.ToInt32(text[0].ToString());
            int count = 1;
            for (int i = 1; i < text.Length; i++)
            {
                if (Convert.ToInt32(text[i].ToString()) == lastnumber)
                    count++;
                else
                {
                    file.WriteLine($"Quantity of {lastnumber} is {count}");
                    count = 1;
                    lastnumber = Convert.ToInt32(text[i].ToString());
                }
            }
            file.Close();
            read.Close();
        }
        public static void File18()
        {
            StreamReader read = File.OpenText(path);
            char[] text = read.ReadToEnd().ToCharArray();
            for (int i = 1; i < text.Length - 1; i++)
            {
                int firstnumber = Convert.ToInt32(text[i - 1].ToString());
                int secondnumber = Convert.ToInt32(text[i + 1].ToString());
                int number = Convert.ToInt32(text[i].ToString());
                if (number < firstnumber && number < secondnumber)
                {
                    Console.WriteLine(number);
                    return;
                }
            }
            Console.WriteLine("No local minimum numbers.");
            read.Close();
        }
        public static void File19()
        {
            StreamReader read = File.OpenText(path);
            char[] text = read.ReadToEnd().ToCharArray();
            int maximum = 0;
            for (int i = 1; i < text.Length - 1; i++)
            {
                int firstnumber = Convert.ToInt32(text[i - 1].ToString());
                int secondnumber = Convert.ToInt32(text[i + 1].ToString());
                int number = Convert.ToInt32(text[i].ToString());
                if (number > firstnumber && number > secondnumber)
                    maximum = number;
            }
            Console.WriteLine(maximum);
            read.Close();
        }
        public static void File20()
        {
            StreamReader read = File.OpenText(path);
            char[] text = read.ReadToEnd().ToCharArray();
            int count = 0;
            for (int i = 1; i < text.Length - 1; i++)
            {
                int firstnumber = Convert.ToInt32(text[i - 1].ToString());
                int secondnumber = Convert.ToInt32(text[i + 1].ToString());
                int number = Convert.ToInt32(text[i].ToString());
                if (number > firstnumber && number > secondnumber || number < firstnumber && number < secondnumber)
                    count++;
            }
            Console.WriteLine(count);
            read.Close();
        }
        public static void File25()
        {
            StreamReader read = File.OpenText(path);
            char[] text = read.ReadToEnd().ToCharArray();
            read.Close();
            StreamWriter write = File.CreateText(path);
            foreach (var item in text)
            {
                write.Write($"{Math.Pow(Convert.ToInt32(item.ToString()), 2)}, ");
            }
            write.Close();
        }
        public static void File26()
        {
            StreamReader read = File.OpenText(path);
            char[] text = read.ReadToEnd().ToCharArray();
            read.Close();
            StreamWriter write = File.CreateText(path);
            int minindex = 0;
            int maxindex = 0;
            int min = Convert.ToInt32(text[0].ToString());
            int max = min;
            for (int i = 1; i < text.Length; i++)
            {
                int number = Convert.ToInt32(text[i].ToString());
                if (number < min)
                {
                    min = number;
                    minindex = i;
                }
                if (number > max)
                {
                    max = number;
                    maxindex = i;
                }
            }
            text[minindex] = max.ToString()[0];
            text[maxindex] = min.ToString()[0];
            foreach (var item in text)
            {
                write.Write(item);
            }
            write.Close();
        }
        public static void File27()
        {
            StreamReader read = File.OpenText(path);
            char[] text = read.ReadToEnd().ToCharArray();
            read.Close();
            StreamWriter write = File.CreateText(path);
            for (int i = 0; i < (text.Length + 1) / 2; i++)
            {
                write.Write(text[i]);
                write.Write(text[text.Length - 1 - i]);
            }
            write.Close();
        }
        public static void File28()
        {
            StreamReader read = File.OpenText(path);
            char[] text = read.ReadToEnd().ToCharArray();
            read.Close();
            StreamWriter write = File.CreateText(path);
            write.Write(text[0]);
            for (int i = 1; i < text.Length - 1; i++)
            {
                int firstnumber = Convert.ToInt32(text[i - 1].ToString());
                int number = Convert.ToInt32(text[i].ToString());
                int secondnumber = Convert.ToInt32(text[i + 1].ToString());
                double avarage = (number + firstnumber + secondnumber) / 3;
                write.Write(avarage);
            }
            write.Write(text[text.Length - 1]);
            write.Close();
        }
        public static void File29()
        {
            StreamReader read = File.OpenText(path);
            char[] text = read.ReadToEnd().ToCharArray();
            read.Close();
            StreamWriter write = File.CreateText(path);
            for (int i = 0; i < 50; i++)
            {
                write.Write(text[i]);
            }
            write.Close();
        }
        public static void File30()
        {
            StreamReader read = File.OpenText(path);
            char[] text = read.ReadToEnd().ToCharArray();
            read.Close();
            StreamWriter write = File.CreateText(path);
            for (int i = 0; i < text.Length - 2; i++)
            {
                write.Write(text[i]);
            }
            write.Close();
        }
        public static void File37()
        {
            StreamReader read = File.OpenText(path);
            char[] text = read.ReadToEnd().ToCharArray();
            read.Close();
            StreamWriter write = File.CreateText(path);

            for (int i = 0; i < text.Length; i++)
                write.Write(text[i]);
            for (int i = text.Length - 1; i >= 0; i--)
                write.Write(text[i]);

            write.Close();
        }
        public static void File38()
        {
            StreamReader read = File.OpenText(path);
            char[] text = read.ReadToEnd().ToCharArray();
            read.Close();
            StreamWriter write = File.CreateText(path);
            for (int i = 0; i < text.Length; i++)
            {
                if (i % 2 == 1)
                    write.Write(text[i]);
                write.Write(text[i]);
            }
            write.Close();
        }
        public static void File39()
        {
            StreamReader read = File.OpenText(path);
            char[] text = read.ReadToEnd().ToCharArray();
            read.Close();
            StreamWriter write = File.CreateText(path);
            for (int i = 0; i < text.Length; i++)
            {
                if (Convert.ToInt32(text[i].ToString()) >= 5 && Convert.ToInt32(text[i].ToString()) <= 10)
                    write.Write(text[i]);
                write.Write(text[i]);
            }
            write.Close();
        }
        public static void File40()
        {
            StreamReader read = File.OpenText(path);
            char[] text = read.ReadToEnd().ToCharArray();
            read.Close();
            StreamWriter write = File.CreateText(path);
            for (int i = 0; i < text.Length; i++)
            {
                if (i % 2 == 0)
                    write.Write("00");
                else
                    write.Write(text[i]);
            }
            write.Close();
        }
        public static void File41()
        {
            StreamReader read = File.OpenText(path);
            char[] text = read.ReadToEnd().ToCharArray();
            read.Close();
            StreamWriter write = File.CreateText(path);
            for (int i = 0; i < text.Length; i++)
            {
                int number = Convert.ToInt32(text[i].ToString());
                if (number >= 0)
                    write.Write("000");
                else
                    write.Write(text[i]);
            }
            write.Close();
        }
        public static void File48(string path2, string path3, string path4)
        {
            StreamReader read1 = File.OpenText(path2);
            StreamReader read2 = File.OpenText(path3);
            StreamReader read3 = File.OpenText(path4);
            char[] text1 = read1.ReadToEnd().ToCharArray();
            char[] text2 = read2.ReadToEnd().ToCharArray();
            char[] text3 = read3.ReadToEnd().ToCharArray();
            StreamWriter write = File.CreateText(path);
            for (int i = 0; i < text1.Length; i++)
            {
                write.Write(text1[i]);
                write.Write(text2[i]);
                write.Write(text3[i]);
            }
            read1.Close();
            read2.Close();
            read3.Close();
            write.Close();
        }
        public static void File49(string path2, string path3, string path4, string path5)
        {
            StreamReader read1 = File.OpenText(path2);
            StreamReader read2 = File.OpenText(path3);
            StreamReader read3 = File.OpenText(path4);
            StreamReader read4 = File.OpenText(path5);
            char[] text1 = read1.ReadToEnd().ToCharArray();
            char[] text2 = read2.ReadToEnd().ToCharArray();
            char[] text3 = read3.ReadToEnd().ToCharArray();
            char[] text4 = read4.ReadToEnd().ToCharArray();
            StreamWriter write = File.CreateText(path);
            for (int i = 0; i < text1.Length; i++)
            {
                write.Write(text1[i]);
                write.Write(text2[i]);
                write.Write(text3[i]);
                write.Write(text4[i]);
            }
            read1.Close();
            read2.Close();
            read3.Close();
            read4.Close();
            write.Close();
        }
        public static void File74(int I, int J)
        {
            Console.WriteLine(File.ReadAllLines(path)[I][J]);
        }
    }
}
