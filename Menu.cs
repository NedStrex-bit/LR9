using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba9
{
    internal class Menu
    {
        int n;
        public static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Для дальнейшей работы необходим текст. Выберите формат работы:"
                + "\n1. Часть 1"
                + "\n2. Часть 2"
                + "\n3. Часть 3"
                + "\n4. Выход");
            Console.Write("\nВведите номер нужного варианта: ");
        }
        public static void Finishing()//Спрашивает хочет ли пользователь закончить работу со строкой
        {
            bool isCorrect = true;
            string answers = "1";
            do
            {
                Console.WriteLine("\nЗавершить работу с данной Частью? 1 - Да ");
                string answer2 = Console.ReadLine();
                if (answers.Contains(answer2))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Неправильный выбор. Повторите попытку");
                    isCorrect = false;
                }
            } while (!isCorrect);
        }
        public static void ShowMenuForSecondPart()
        {

            {
                Console.WriteLine("\n Часть 2");
                Console.WriteLine("1. Добавить к сторонам 1");
                Console.WriteLine("2. Отнять от сторон 1");
                Console.WriteLine("3. Значение площади описанной вокруг прямоугольника окружности");
                Console.WriteLine("4. Результатом является true, если прямоугольник является квадратом, и false в противном случае.");
                Console.WriteLine("5. + увеличение сторон на заданное число");
                Console.WriteLine("6. - уменьшение сторон на заданное число");
                Console.WriteLine("7. Бул имплицит");
                Console.WriteLine("8. Назад");
                Console.Write("\nВведите номер нужного варианта: ");
            }
        }
    }
}
