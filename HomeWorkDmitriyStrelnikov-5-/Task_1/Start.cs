using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task_1
{
    class Start
    {
        string login;

        public void Enter()
        {

            Console.Write("Введите логин: ");
            string _login = Console.ReadLine();
            login = _login;

        }
        public void Chek()
        {
            bool i = true;
            while (i)
            {
                Enter();

                if (login.Length >= 2 && login.Length <= 10)
                {
                    if (char.IsLetter(login[0]))
                    {
                        for (int a = 0; a < login.Length; a++)
                        {
                            if (login[a] >= 'A' && login[a] <= 'Z' || login[a] >= 'a' && login[a] <= 'z' || login[a] >= '0' && login[a] <= '9')
                            {

                            }
                            else
                            {
                                Console.WriteLine("Логин должен состоять из латинских букв и цифр!");
                                break;
                            }
                            Console.WriteLine("Логин введен верно!");
                            i = false;
                            Console.ReadLine();
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Логин не должен начинаться с цифры!");
                    }
                }
                else
                {
                    Console.WriteLine("Логин должен содержать от 2 до 10 символов!");
                }
            }

        }

        public void ChekReg()
        {
            bool i = true;
            while (i)
            {
                Enter();
                Regex myReg = new Regex(@"^[a-z]+[a-z0-9]{1,9}$", RegexOptions.IgnoreCase | RegexOptions.Compiled);
                if (myReg.IsMatch(login))
                {
                    Console.WriteLine("Логин введен верно!");
                }
                else
                {
                    Console.WriteLine("1. Логин должен состоять от 2 до 10 символов." +
                        "\n2. Только из цифр и латинских букв. " +
                        "\n3. Первая буква Латинская");
                }
            }
        }
        public void Option()
        {
            Console.WriteLine("Выбериет один вариант:" +
                "\n1. Без использования регулярных выражений." +
                "\n2. С использованием регулярных выражени ");
            byte a = byte.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Chek();
                    break;
                case 2:
                    ChekReg();
                    break;
            }
        }
    }
}
