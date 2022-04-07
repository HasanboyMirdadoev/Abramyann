using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Abramyann
{
    class Text
    {
        static string path = $"{Directory.GetCurrentDirectory()}\\setting.txt";
        public static void Text1(int N, int K)
        {
            StreamWriter write = File.CreateText(path);
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < K; j++)
                {
                    write.Write("*");
                }
                write.WriteLine();
            }
            write.Close();
        }
        public static void Text2(int N)
        {
            StreamWriter write = File.CreateText(path);
            for (int i = 1; i <= N; i++)
            {
                byte[] bytes = new byte[0];
                for (int j = 1; j <= i; j++)
                {
                    Array.Resize(ref bytes, bytes.Length + 1);
                    bytes[bytes.Length - 1] = Convert.ToByte(j + 96);
                }
                string text = Encoding.Default.GetString(bytes);
                write.WriteLine(text.Trim());
            }
            write.Close();
        }
        public static void Text3(int N)
        {
            StreamWriter write = File.CreateText(path);
            for (int i = 1; i <= N; i++)
            {
                byte[] bytes = new byte[0];
                for (int j = 1; j <= i; j++)
                {
                    Array.Resize(ref bytes, bytes.Length + 1);
                    bytes[bytes.Length - 1] = Convert.ToByte(i + 96);
                }
                string text = Encoding.Default.GetString(bytes);
                for (int j = i + 1; j <= N; j++)
                    text += "*";
                write.WriteLine(text);
            }
            write.Close();
        }
        public static void Text4()
        {
            int letter_count = 0;
            int other_count = 0;
            foreach (var item in File.ReadAllLines(path))
            {
                foreach (var item2 in item)
                {
                    int code = Convert.ToInt32(item2);
                    if (code >= 65 && code <= 90 || code >= 97 && code <= 122 || code >= 192 && code <= 255 || code == 168 || code == 184)
                        letter_count++;
                    else other_count++;
                }
            }
            Console.WriteLine($"Letters count: {letter_count}");
            Console.WriteLine($"Symbols count: {other_count}");
        }
        public static void Text5(string S)
        {
            StreamReader read = File.OpenText(path);
            string text = read.ReadToEnd();
            read.Close();
            StreamWriter write = File.CreateText(path);
            write.Write(text);
            write.WriteLine();
            write.Write(S);
            write.Close();
        }
        public static void Text6(string path2)
        {
            StreamReader read = File.OpenText(path);
            StreamReader read2 = File.OpenText(path2);
            string text = read.ReadToEnd();
            string text2 = read2.ReadToEnd();
            read.Close();
            read2.Close();
            StreamWriter write = File.CreateText(path);
            write.Write(text);
            write.WriteLine();
            write.Write(text2);
            write.Close();
        }
        public static void Text7(string S)
        {
            StreamReader read = File.OpenText(path);
            string text = read.ReadToEnd();
            read.Close();
            StreamWriter write = File.CreateText(path);
            write.Write(S);
            write.WriteLine();
            write.Write(text);
            write.Close();
        }
        public static void Text8(string path2)
        {
            StreamReader read = File.OpenText(path);
            StreamReader read2 = File.OpenText(path2);
            string text = read.ReadToEnd();
            string text2 = read2.ReadToEnd();
            read.Close();
            read2.Close();
            StreamWriter write = File.CreateText(path);
            write.Write(text2);
            write.WriteLine();
            write.Write(text);
            write.Close();
        }
        public static void Text56(string path2)
        {
            StreamReader read = File.OpenText(path);
            byte[] bytes = Encoding.Default.GetBytes(read.ReadToEnd());
            read.Close();
            byte[] new_bytes = new byte[1];
            new_bytes[0] = bytes[0];
            for (int i = 1; i < bytes.Length; i++)
            {
                bool exists = false;
                for (int j = 0; j < new_bytes.Length; j++)
                {
                    if (new_bytes[j] == bytes[i])
                    {
                        exists = true;
                        break;
                    }
                }
                if(!exists)
                {
                    Array.Resize(ref new_bytes, new_bytes.Length + 1);
                    new_bytes[new_bytes.Length - 1] = bytes[i];
                }
            }
            string text = Encoding.Default.GetString(new_bytes);
            StreamWriter write = File.CreateText(path2);
            write.WriteLine(text);
            write.Close();
        }
    }
}
