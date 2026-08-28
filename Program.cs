using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Смоделируйте работу простого калькулятора. Программа должна запрашивать 2 числа,
            а затем – код операции (например, 1 – сложение, 2 – вычитание, 3 – произведение,
            4 – частное). После этого на консоль выводится ответ. Используйте обработку
            исключений для защиты от ввода некорректных данных.
            */

            Console.WriteLine("Вас приветствует калькулятор!");

            try
            {
                Console.Write("Введите целое число. X=");
                int x = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите целое число. Y=");
                int y = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите код операции:");
                Console.WriteLine("    1 - сложение");
                Console.WriteLine("    2 - вычитание");
                Console.WriteLine("    3 - произведение");
                Console.WriteLine("    4 - частное");
                Console.Write("Ваш выбор: ");
                int a = Convert.ToInt32(Console.ReadLine());

                int result;

                switch (a)
                {
                    case 1:
                        result = x + y;
                        break;
                    case 2:
                        result = x - y;
                        break;
                    case 3:
                        result = x * y;
                        break;
                    case 4:
                        result = x / y;
                        break;
                    default:
                        throw new Exception("Нет операции с указанным номером");
                }

                Console.WriteLine("Результат = " + result);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Ошибка! " + ex.Message);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ошибка! Деление на ноль невозможно.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Для завершения нажмите на клавишу");
            Console.ReadKey();
        }
    }
}
