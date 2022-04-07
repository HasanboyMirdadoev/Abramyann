using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abramyann
{
    class String
    {
        public static void String13(string C)
        {
            int counter = 0;
            foreach (char ch in C)
            {
                if (char.IsDigit(ch))
                    counter++;
            }
            Console.WriteLine(counter);
        }
        public static void String14(string s)
        {
            byte[] b = Encoding.Default.GetBytes(s);
            int count = 0;
            foreach (byte bt in b)
            {
                if (bt >= 65 && bt <= 122)
                    count++;
            }
            Console.WriteLine(count);
        }
        public static void String15(string s)
        {
            int count = 0;
            byte[] b = Encoding.Default.GetBytes(s);
            foreach (var bt in b)
            {
                if ((bt >= 65 && bt <= 122) || (bt >= 192 && bt <= 255) || bt == 168 || bt == 184)
                    count++;
            }
            Console.WriteLine(count);
        }
        public static void String20(string s)
        {
            foreach (var ch in s)
            {
                Console.WriteLine(ch);
            }
        }
        public static void String21(string s)
        {
            for (int i = s.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(s[i]);
            }
        }
        public static void String23(string s)
        {
            int result = Convert.ToInt16(s[0].ToString());
            for (int i = 2; i < s.Length; i += 2)
            {
                if (s[i - 1] == '-')
                    result -= Convert.ToInt32(s[i].ToString());
                else
                    result += Convert.ToInt32(s[i].ToString());
            }
            Console.WriteLine(result);
        }
        public static void String26(string S, int N)
        {
            int farq = N - S.Length;
            string newS = "";
            if (farq > 0)
            {
                for (int i = 0; i < S.Length + farq; i++)
                {
                    if (i < farq)
                        newS += ".";
                    else
                        newS += S[i - farq];
                }
            }
            else
            {
                for (int i = -farq; i < S.Length; i++)
                {
                    newS += S[i];
                }
            }
            Console.WriteLine(newS);
        }
        public static void String27(int N1, int N2, string S1, string S2)
        {
            string newS1 = "";
            string newS2 = "";
            for (int i = 0; i < N1; i++)
                newS1 += S1[i];
            for (int i = 0; i < N2; i++)
                newS2 += S2[i];
            Console.WriteLine("__________________");
            Console.WriteLine(newS1);
            Console.WriteLine(newS2);
        }
        public static void String28(char C, string S)
        {
            string newS = "";
            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] == C)
                    newS += C;
                newS += S[i];
            }
            Console.WriteLine(newS);
        }
        public static void String29(char C, string S, string S0)
        {
            string newS = S[0].ToString();
            for (int i = 0; i < S.Length - 1; i++)
            {
                if (S[i + 1] == C)
                    newS += S0;
                newS += S[i + 1];
            }
            Console.WriteLine(newS);
        }
        public static void String30(char C, string S, string S0)
        {
            string newS = "";
            for (int i = 0; i < S.Length; i++)
            {
                newS += S[i];
                if (S[i] == C)
                    newS += S0;
            }
            Console.WriteLine(newS);
        }
        public static void String31(string S, string S0)
        {
            for (int i = 0; i < S.Length - S0.Length + 1; i++)
            {
                string comp = "";
                for (int j = i; j < i + S0.Length; j++)
                {
                    comp += S[j];
                }
                if (comp == S0)
                {
                    Console.WriteLine(true);
                    return;
                }
            }
            Console.WriteLine(false);
        }
        public static void String32(string S, string S0)
        {
            int count = 0;
            for (int i = 0; i < S.Length - S0.Length + 1; i++)
            {
                string comp = "";
                for (int j = i; j < i + S0.Length; j++)
                    comp += S[j];
                if (comp == S0)
                    count++;
            }
            Console.WriteLine(count);
        }
        public static void String33(string S, string S0)
        {
            int first_index = 0;
            int last_index = 0;
            for (int i = 0; i < S.Length - S0.Length + 1; i++)
            {
                string comp = "";
                for (int j = i; j < i + S0.Length; j++)
                    comp += S[j];
                if (comp == S0)
                {
                    first_index = i;
                    last_index = i + S0.Length;
                    break;
                }
            }
            string newS = "";
            for (int i = 0; i < first_index; i++)
                newS += S[i];
            for (int i = last_index; i < S.Length; i++)
                newS += S[i];
            Console.WriteLine(newS);
        }
        public static void String34(string S, string S0)
        {
            int first_index = 0;
            int last_index = 0;
            for (int i = 0; i < S.Length - S0.Length + 1; i++)
            {
                string comp = "";
                for (int j = i; j < i + S0.Length; j++)
                    comp += S[j];
                if (comp == S0)
                {
                    first_index = i;
                    last_index = i + S0.Length;
                }
            }
            string newS = "";
            for (int i = 0; i < first_index; i++)
                newS += S[i];
            for (int i = last_index; i < S.Length; i++)
                newS += S[i];
            Console.WriteLine(newS);
        }
        public static void String35(string S, string S0)
        {
            string newS = "";
            for (int i = 0; i < S.Length - S0.Length + 1; i++)
            {
                string word = "";

                for (int j = i; j < i + S0.Length; j++)
                    word += S[j];

                if (word == S0)
                    i = i + S0.Length - 1;
                else
                    newS += S[i];
            }
            for (int i = S.Length - S0.Length + 1; i < S.Length; i++)
                newS += S[i];
            Console.WriteLine(newS);
        }
        public static void String36(string S, string S1, string S2)
        {
            int first_index = 0;
            int last_index = 0;
            bool includes = false;
            for (int i = 0; i < S.Length - S1.Length + 1; i++)
            {
                string word = "";
                for (int j = i; j < i + S1.Length; j++)
                    word += S[j];

                if (word == S1)
                {
                    first_index = i;
                    last_index = i + S1.Length - 1;
                    includes = true;
                    break;
                }
            }

            string newS = "";
            for (int i = 0; i < first_index; i++)
                newS += S[i];
            if (includes)
                newS += S2;
            for (int i = last_index + 1; i < S.Length; i++)
                newS += S[i];
            Console.WriteLine(newS);
        }
        public static void String37(string S, string S1, string S2)
        {
            int first_index = 0;
            int last_index = 0;
            bool includes = false;
            for (int i = 0; i < S.Length - S1.Length + 1; i++)
            {
                string word = "";
                for (int j = i; j < i + S1.Length; j++)
                    word += S[j];

                if (word == S1)
                {
                    first_index = i;
                    last_index = i + S1.Length - 1;
                    includes = true;
                }
            }

            string newS = "";
            for (int i = 0; i < first_index; i++)
                newS += S[i];
            if (includes)
                newS += S2;
            for (int i = last_index + 1; i < S.Length; i++)
                newS += S[i];
            Console.WriteLine(newS);
        }
        public static void String38(string S, string S1, string S2)
        {
            string newS = "";
            for (int i = 0; i < S.Length - S1.Length + 1; i++)
            {
                string word = "";
                for (int j = i; j < i + S1.Length; j++)
                    word += S[j];

                if (word == S1)
                {
                    i = i + S1.Length - 1;
                    newS += S2;
                }
                else
                    newS += S[i];
            }
            for (int i = S.Length - S1.Length + 1; i < S.Length; i++)
                newS += S[i];
            Console.WriteLine(newS);
        }
        public static void String39(string S)
        {
            if (S.Split(' ').Length >= 3)
                Console.WriteLine(S.Split(' ')[1]);
            else
                Console.WriteLine(".");
        }
        public static void String40(string S)
        {
            string[] array = S.Split(' ');
            for (int i = 1; i < array.Length - 1; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
        public static void String41(string S)
        {
            int counter = 1;
            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] == ' ')
                    counter++;
            }
            Console.WriteLine(counter);
        }
        public static void String42(string S)
        {
            int counter = 0;
            string[] array = S.Split(' ');

            for (int i = 0; i < array.Length; i++)
                if (array[i][0] == array[i][array[i].Length - 1])
                    counter++;

            Console.WriteLine(counter);
        }
        public static void String43(string S)
        {
            int counter = 0;
            string[] words = S.Split(' ');
            foreach (string word in words)
            {
                foreach (char letter in word)
                {
                    if (letter == 'А')
                    {
                        counter++;
                        break;
                    }
                }
            }
            Console.WriteLine(counter);
        }
        public static void String44(string S)
        {
            int count = 0;
            string[] words = S.Split(' ');
            foreach (string word in words)
            {
                int counter = 0;
                foreach (char letter in word)
                {
                    if (letter == 'А')
                    {
                        counter++;
                    }
                }
                if (counter == 3) count++;
            }
            Console.WriteLine(count);
        }
        public static void String45(string S)
        {
            string[] words = S.Split(' ');
            int min = words[0].Length;

            foreach (string word in words)
                if (min > word.Length)
                    min = word.Length;
            Console.WriteLine(min);
        }
        public static void String53(string S)
        {
            int counter = 0;
            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] == '~')
                    counter++;
            }
            Console.WriteLine(counter);
        }
        public static void String55(string S)
        {
            string[] words = S.Split(' ');
            string longest_word = words[0];

            foreach (string word in words)
                if (longest_word.Length <= word.Length)
                    longest_word = word;

            Console.WriteLine(longest_word);
        }
        public static void String56(string S)
        {
            string[] words = S.Split(' ');
            string smallest_word = words[0];

            foreach (string word in words)
                if (smallest_word.Length >= word.Length)
                    smallest_word = word;

            Console.WriteLine(smallest_word);
        }
        public static void String57(string S)
        {
            string newS = "";
            string[] words = S.Split(' ');
            foreach (string word in words)
            {
                if (word != "")
                    newS += word + " ";
            }
            Console.WriteLine(newS.Trim());
        }
        public static void String58(string S)
        {
            string name = S.Split('\\')[S.Split('\\').Length - 1]
                .Split('.')[0];
            Console.WriteLine(name);
        }
        public static void String59(string S)
        {
            string name = S.Split('\\')[S.Split('\\').Length - 1]
                .Split('.')[1];
            Console.WriteLine(name);
        }
        public static void String60(string S)
        {
            Console.WriteLine(S.Split('\\')[1]);
        }
        public static void String61(string S)
        {
            Console.WriteLine(S.Split('\\')[S.Split('\\').Length - 2]);
        }
        public static void String62(string S)
        {
            byte[] bytes = Encoding.Default.GetBytes(S);
            for (int i = 0; i < bytes.Length; i++)
            {
                if (bytes[i] > 192 && bytes[i] <= 255)
                {
                    if (bytes[i] == 223) bytes[i] = 192;
                    else if (bytes[i] == 255) bytes[i] = 224;
                    else bytes[i] += 1;
                }
            }
            string newS = Encoding.Default.GetString(bytes);
            Console.WriteLine(newS);
        }
    }
}
