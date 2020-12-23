using System;
namespace Lesson_5_Task_3
{
    public class Option
    {
        public Option()
        {
            bool a = true;
            while (a)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Чтобы начать выполнение программы нажмите - 1" +
                    "\nЧтобы закончить выполнение прогрммы нажмите - 2");
                Console.ResetColor();
                int b = int.Parse(Console.ReadLine());

                switch (b)
                {
                    case 1:

                        var c = new Message();

                        break;

                    case 2:

                        a = false;

                        break;
                }
            }
        }
    }
}