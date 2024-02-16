using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Laba9
{
    internal class Program
    {
        //Атрибутом класса называется именованное свойство класса, описывающее множество значений, которые могут принимать экземпляры этого свойства.
        //Свойства классов - это по сути переменные внутри классов, в которые можно записывать данные
        static void Main(string[] args)
        {
            
            
            Rectangle r1 = new Rectangle();
            bool ok = false;
            double rezultat;
            Rectangle r= new Rectangle(10,5);
            Rectangle r2 = new Rectangle(r);
            RectangleArray ra = new RectangleArray(0); 
            r.Show();
            r1.Show();
            r2.Show();
            Console.WriteLine("1 massiv");
            ra.Show();
            RectangleArray ra2 = new RectangleArray(ra);
            Console.WriteLine("2 massiv");
            ra2.Show();
            ra[0] = new Rectangle(50,3);
            //Console.WriteLine(ra[0]);
            Console.WriteLine("1 massiv");
            ra.Show();
            Console.WriteLine("2 massiv");
            ra2.Show();
            
            try
            {
                ra2[100] = new Rectangle(100, 0); 
                ra2.Show();
            
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            rezultat = SpaceArray(ra);
            Console.WriteLine($"среднее арифметическое площадей описанных вокруг прямоугольников окружностей 1 массива: {rezultat}");
            Console.WriteLine($"Создано {Rectangle.GetCount()} объектов");
            Console.WriteLine($"Создано {RectangleArray.GetCount()} коллекций");
            int choice;
            do
            {
                Menu.MainMenu();
                choice = CheckElement.EnterNumber();

                switch (choice)
                {
                    case 1:
                        int n = 1;
                        Rectangle r999 = new Rectangle(10, 5);
                        r.Show();
                        Console.WriteLine("Введите N");
                        n = CheckElement.InputElement(n);
                        Rectangle rek = new Rectangle();
                        r = Rectangle.IncreaseRectangle(n,r);
                        //if (r.Width > 46340.9499 || r.Length > 46340.9499 || r.Width < 0.0001 || r.Length < 0.0001)
                        //{
                        //    Console.WriteLine("Нельзя ширину или длину больше 46340.9499 и меньше 0.0001");
                        //}
                        //else
                        //{
                        
                        //}
                        Menu.Finishing();
                        break;
                    case 2:
                        
                        int choice2;
                        do
                        {
                            Menu.ShowMenuForSecondPart();
                            choice2 = CheckElement.EnterNumber();

                            switch (choice2)
                            {
                                case 1:

                                    r++;
                                    //if (r.Width > 46340.9499 || r.Length > 46340.9499 || r.Width < 0.0001 || r.Length < 0.0001)
                                    //{
                                    //    Console.WriteLine("Нельзя ширину или длину больше 46340.9499 и меньше 0.0001");
                                    //}
                                    //else
                                    //{
                                    //    r.Show();

                                    //}
                                    break;
                                case 2:
                                    r--;
                                    //if (r.Width > 46340.9499 || r.Length > 46340.9499 || r.Width < 0.0001 || r.Length < 0.0001)
                                    //{
                                    //    Console.WriteLine("Нельзя ширину или длину больше 46340.9499 и меньше 0.0001");
                                    //}
                                    //else
                                    //{
                                    //    r.Show();
                                    //}
                                    break;
                                case 3:
                                    double result;
                                    result = Math.Pow(r.Width, 2) + Math.Pow(r.Length, 2);
                                    result = Math.Sqrt(result);
                                    result = result / 2;
                                    result = Math.PI * Math.Pow(result, 2);
                                    Console.WriteLine($"площадь описанной вокруг прямоугольника окружности: {result}");

                                    break;
                                case 4:
                                    Console.WriteLine("Массив Rectangle");
                                    ra.Show();
                                    rezultat = SpaceArray(ra);
                                    if (ra.Length == 0)
                                    {
                                        Console.WriteLine("Массив пуст");
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine($"среднее арифметическое площадей описанных вокруг прямоугольников окружностей 1 массива: {rezultat}");
                                    }
                                    break;
                                    case 5:
                                    int d = 1;
                                    Console.WriteLine("Введите d");
                                    d = CheckElement.InputElement(d);

                                    r = r + d;
                                    r.Show();
                                    break;

                                        case 6:
                                    int d1 = 1;
                                    Console.WriteLine("Введите d");
                                    d = CheckElement.InputElement(d1);
                                    r = r - d;
                                    r.Show();
                                    break;

                                    case 7:
                                    Console.WriteLine("Данный прямоугольник - квадрат?");
                                    bool isSquare = r;
                                    if (isSquare == true)
                                    {
                                        Console.WriteLine("Kvadrat");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ne kvadrat");
                                    }
                                    break;

                                    case 8:
                                    Console.WriteLine("Вы вышли из программы");
                                    break;
                            }
                        } while (choice2 != 7);

                        break;
                    case 3:
                        Console.WriteLine("Массив Rectangle");
                        ra.Show();
                        rezultat = SpaceArray(ra);
                        Console.WriteLine($"среднее арифметическое площадей описанных вокруг прямоугольников окружностей 1 массива: {rezultat}");
                        break;
                    case 4:
                        Console.WriteLine("Вы вышли из программы");
                        break; 
                }
            } while (choice != 4);

        }
        public static double SpaceArray(RectangleArray re)
        {
            double result;
            double result2 =0;
            for (int i = 0; i < re.Length; i++)
            {
                result = (double)re[i];
                result2+=result;
            }
            result2 = (double)result2 / re.Length;
            return result2;

        }
    }
}
