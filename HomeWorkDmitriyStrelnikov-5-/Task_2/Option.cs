using System;
namespace Task_2
{
    public class Option
    {
        public Option()
        {
            Console.WriteLine("Выберите какую часть из задания выполнить. " +
                "\n1 - Вывести только те слова сообщения,  которые содержат не более n букв." +
                "\n2 - Удалить из сообщения все слова, которые заканчиваются на заданный символ." +
                "\n3 - Найти самое длинное слово сообщения." +
                "\n4 - Сформировать строку с помощью StringBuilder из самых длинных слов сообщения. ");
            int a = int.Parse(Console.ReadLine());
            var file = new Message("date.txt");
            file.TextOutput();
            switch (a)
            {
                case 1:

                    file.LengthWords();

                    break;
                case 2:

                    file.DeletWords();

                    break;
                case 3:

                    file.LongestWord();

                    break;
                case 4:

                    file.StringLongestWords();

                    break;
            }
        }
        public void Enter()
        {

        }
    }
}