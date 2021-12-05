using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_9_Обработка_исключений
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует калькулятор");
            Console.WriteLine("Введите два числа:");
            try
            {


                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите код операции");
                Console.WriteLine("1- сложение");
                Console.WriteLine("2- вычитание");
                Console.WriteLine("3-произведение");
                Console.WriteLine("4-деление");

                int c = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ваш выбор:{0}", c);


                switch (c)
                {
                    case 1:
                        {
                            Console.WriteLine("Сумма равна: {0}", a + b);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Разность равна: {0}", a - b);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Произведение равно: {0}", a * b);
                            break;
                        }
                    case 4:
                        {
                            try
                            {
                                Console.WriteLine("Частное равно: {0}", a / b);

                            }
                            catch (DivideByZeroException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Ошибка: недопустимый код операции");
                            break;
                        }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка! Входная строка имела неверный формат");
            }

            Console.ReadKey();
        }
    }
}
