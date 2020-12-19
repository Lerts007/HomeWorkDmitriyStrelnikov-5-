using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Start
    {
        string login;

        public void Enter()
        {

            Console.WriteLine("Введите логин: ");
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
                            if (login[a] >= 'a' && login[a] <= 'z' || login[a] >= '0' && login[a] <= '9')
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
    }
}
