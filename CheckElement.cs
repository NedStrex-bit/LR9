using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba9
{
    internal class CheckElement
    {
        public static int InputElement(int n)
        {
            bool ok;
            do
            {
                string buf = Console.ReadLine();
                ok = int.TryParse(buf, out n) && n >= 0 && n <= 1000000;
                if (!ok) Console.WriteLine("Oшибка! Вы ввели отрицательное число или число больше 1000000 ");
            } while (!ok);
            return n;
        }
        public static Rectangle InputElementRectangle(double lenght,double width)
        {
            bool ok;
            bool ok1;
            do
            {
                string buf = Console.ReadLine();
                ok = double.TryParse(buf, out lenght) && lenght > 0.0001  && lenght < 46340.9499;
                ok1 = double.TryParse(buf, out width) && width > 0.0001 && width < 46340.9499;
                if (!ok && !ok1) Console.WriteLine("Oшибка! Вы ввели отрицательное число или число больше 1000000 ");
            } while (!ok && !ok1);
            return new Rectangle(width, lenght);
        }
        public static int EnterNumber()
        {
            bool isCorrect;
            int number;
            do
            {
                string input = Console.ReadLine();
                isCorrect = int.TryParse(input, out number);
                if (!isCorrect)
                {
                    Console.Write("Неверный ввод, повторите попытку: ");
                }
            } while (!isCorrect);
            return number;
        }
    }
}
