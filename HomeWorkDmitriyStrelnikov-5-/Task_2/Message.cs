using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Task_2
{
    public class Message
    {
        string path;

        public Message(string path)
        {
            this.path = path;
        }

        public void ReadFile(out string[] words, StreamReader sr)
        {
            string line = sr.ReadLine();
            words = line.Split(' ');
        }
        public void ReadFile(out string line, StreamReader sr)
        {
            line = sr.ReadLine();

        }
        public void ReadFile(out string line, out string[] words, StreamReader sr)
        {
            line = sr.ReadLine();
            words = line.Split(' ');

        }

        public void LengthWords()
        {
            Console.Write("\nВведите минимальную длину слова: ");
            int length = int.Parse(Console.ReadLine());
            int b = 1;
            StreamReader sr = new StreamReader(path);

            while (!sr.EndOfStream)
            {
                string[] words;
                ReadFile(out words, sr);


                for (int i = 0; i < words.Length; i++)
                {
                    char[] trimChar = { '!', '?', '«', '»', '.', ',', '"', ':', ';', '(', ')', '-', '_' };
                    string a = words[i];
                    a = a.Trim(trimChar);
                    if (a.Length >= length)
                    {

                        Console.WriteLine("{0}. {1}", b++, a);
                        Console.WriteLine();
                    }

                }
            }
            Console.ReadLine();
            sr.Close();

        }

        public void TextOutput()
        {
            string[] line;
            Console.WriteLine("Текст хранящийся в файле.\n");
            StreamReader sr = new StreamReader(path);
            Console.ForegroundColor = ConsoleColor.Green;
            while (!sr.EndOfStream)
            {
                ReadFile(out line, sr);
                for (int i = 0; i < line.Length; i++)
                {
                    Console.Write(line[i] + " ");
                }
                Console.WriteLine();

            }
            Console.ResetColor();
            sr.Close();

        }

        public void DeletWords()
        {
            Console.Write("\nУдалить все слова оканчивающиеся на букву (введите букву):  ");
            string letter = Console.ReadLine();
            Console.WriteLine();
            //string line;
            string[] words;
            string newline = "";
            StreamReader sr = new StreamReader(path);

            while (!sr.EndOfStream)
            {
                ReadFile(out words, sr);
                for (int i = 0; i < words.Length; i++)
                {
                    string a = "" + words[i];
                    if (a != "")
                    {
                        if (a[a.Length - 1] != letter[0])
                        {
                            newline = newline + words[i] + " ";
                        }

                    }


                }

            }

            for (int i = 0; i < newline.Length; i++)
            {
                Console.Write(newline[i]);
            }
            Console.ReadLine();
            sr.Close();

        }

        public void LongestWord()
        {
            string[] words;
            string longestWord = "";
            StreamReader sr = new StreamReader(path);

            while (!sr.EndOfStream)
            {
                ReadFile(out words, sr);
                for (int i = 0; i < words.Length; i++)
                {
                    if (words[i].Length > longestWord.Length)
                    {
                        longestWord = words[i];
                    }
                }

            }
            Console.WriteLine("\nСамое длинное слово в тексте: {0}\n", longestWord);
            Console.ReadLine();
            sr.Close();
        }

        public void StringLongestWords()
        {
            Console.WriteLine("\nСтрока из самых длинных слов при помощи StringBuilder.");
            StreamReader sr = new StreamReader(path);
            StringBuilder sb = new StringBuilder("");
            string b = "";

            while (!sr.EndOfStream)
            {
                string[] words;
                ReadFile(out words, sr);

                for (int i = 0; i < words.Length; i++)
                {
                    char[] trimChar = { '!', '?', '.', ',', '"', ':', ';', '(', ')', '-', '_' };
                    string a = words[i];


                    a = a.Trim(trimChar);
                    if (a.Length == b.Length)
                    {
                        b = a;
                        sb.Append(", " + a);
                    }
                    else if (a.Length > b.Length)
                    {
                        b = a;
                        sb.Clear();
                        sb.Append(a);

                    }


                }

            }
            Console.WriteLine("Самые длинные(ое) слова(о) в тексте: {0}", sb.ToString());
            Console.ReadLine();
            sr.Close();
        }
    }
}