using System;
namespace Lesson_5_Task_3
{
    public class Message
    {
        string s1;
        string s2;
        public Message()
        {
            Console.Write("Введите первую строку: ");
            string s1 = Console.ReadLine();
            this.s1 = s1;

            Console.Write("Введите  вторую  строку: ");
            string s2 = Console.ReadLine();
            this.s2 = s2;

            Permutation();
        }

        public void Permutation()
        {
            if (s1.Length == s2.Length)
            {
                bool a = true;
                for (int i = 0; i < s1.Length; i++)
                {
                    if (a)
                    {
                        for (int j = 0; j < s2.Length; j++)
                        {
                            if (s1[i] == s2[j])
                            {
                                a = true;
                                break;
                            }
                            else
                            {
                                a = false;
                            }
                        }
                    }
                    else
                    {

                    }

                }
                if (a)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nСтроки являются перестановкой.\n");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\nВ строках различные символы. Строки не являются перестановкой.\n");
                    Console.ResetColor();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nСтроки разной длины не являются перестановкой.\n");
                Console.ResetColor();
            }
        }
    }
}