using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Laba9
{
    public class Rectangle
    {
        static int count = 0;
        public double width;
        public double length;
        public double Width
        {
            get => width;
            set
            {
                if (value < 0)
                {
                    width = 0;
                }
                else
                {
                    width = value;
                } 
                    
                    
            }
        }
        //1 часть: закрытые атрибуты, ограничения все в классе в нужных местах, нет статической функции.
        public double Length
        {
            get => length;
            set
            {
                if (value < 0)
                {
                    length = 0;
                }
                else
                {
                    length = value;
                }


            }
        }
        public Rectangle(double w, double l)
        {
            Width = w;
            Length = l;
            count++;
        }
        public Rectangle()
        {
            Width = 1;
            Length = 1;
            count++;
        }
        public Rectangle(Rectangle previousRectangle)
        {
            Width = previousRectangle.width;
            Length = previousRectangle.Length;
            count++;
        }
        public void Show()
        {
            Console.WriteLine($"Ширина {Width}, Высота {Length}.");
        }
        public override string ToString()
        {
            return $"Ширина {Width}, Высота {Length}.";
        }
        public static Rectangle IncreaseRectangle(int N, Rectangle r)
        {
            // Увеличиваем размеры прямоугольника
            r.Width *= N;
            r.Length *= N;

            // Проверяем, не вышли ли размеры за ограничения
            if (r.Width > 46340.9499 || r.Length > 46340.9499 || r.Width < 0.0001 || r.Length < 0.0001)
            {
                Console.WriteLine("Стороны прямоугольника вышли за ограничение");
            }

            return r;
        }
      

        public void Increase(int N)
        {
            Width *= N;
            Length *= N;

            if (Width > 46340.9499 || Length > 46340.9499 || Width < 0.0001 || Length < 0.0001)
            {
                Console.WriteLine("Прямоугольник вышел за ограничение размеров");
                Width /= N;
                Length /= N;
            }
        }
        public static int GetCount() { return count; }
        public static Rectangle operator ++(Rectangle r)
        {
            Rectangle result = new Rectangle(r);
            result.Width = result.Width + 1;
            result.Length = result.Length + 1;
            if (r.Width > 46340.9499 || r.Length > 46340.9499 || r.Width < 0.0001 || r.Length < 0.0001)
            {
                Console.WriteLine("Стороны прямоугольника вышли за ограничение");
            }
            return result;
        }
        public static Rectangle operator --(Rectangle r)
        {
            Rectangle result = new Rectangle(r);
            result.Width = result.Width - 1;
            result.Length = result.Length - 1;
            if (r.Width > 46340.9499 || r.Length > 46340.9499 || r.Width < 0.0001 || r.Length < 0.0001)
            {
                Console.WriteLine("Стороны прямоугольника вышли за ограничение");
            }
            return result;
        }
        public static explicit operator double(Rectangle r)
        {
            double result;
            result = Math.Pow(r.Width, 2) + Math.Pow(r.Length, 2);
            result = Math.Sqrt(result);
            result = result / 2;
            result = Math.PI * Math.Pow(result, 2);
            if (r.Width > 46340.9499 || r.Length > 46340.9499 || r.Width < 0.0001 || r.Length < 0.0001)
            {
                Console.WriteLine("Стороны прямоугольника вышли за ограничение");
            }
            return result;
        }
        public static implicit operator bool(Rectangle r)
        {
                return r.Width == r.Length; //== сравнивает их длину и ширину
        }
        public static Rectangle operator +(Rectangle r, double d)
        {
            Rectangle sum = new Rectangle();
            sum.Width = r.Width + d;
            sum.Length = r.Length + d;
            if (r.Width > 46340.9499 || r.Length > 46340.9499 || r.Width < 0.0001 || r.Length < 0.0001)
            {
                Console.WriteLine("Стороны прямоугольника вышли за ограничение");
            }
            return sum;
        }
        public static Rectangle operator +(double d, Rectangle r)
        {
            Rectangle sum = new Rectangle();
            sum.Width = r.Width + d;
            sum.Length = r.Length + d;
            if (r.Width > 46340.9499 || r.Length > 46340.9499 || r.Width < 0.0001 || r.Length < 0.0001)
            {
                Console.WriteLine("Стороны прямоугольника вышли за ограничение");
            }
            return sum;
        }
        public static Rectangle operator -(Rectangle r, double d)
        {
            Rectangle razn = new Rectangle();
            razn.Width = r.Width - d;
            razn.Length = r.Length - d;
            if (r.Width > 46340.9499 || r.Length > 46340.9499 || r.Width < 0.0001 || r.Length < 0.0001)
            {
                Console.WriteLine("Стороны прямоугольника вышли за ограничение");
            }
            return razn;
        }
        public static Rectangle operator -(double d, Rectangle r)
        {
            Rectangle razn = new Rectangle();
            razn.Width = r.Width - d;
            razn.Length = r.Length - d;
            if (r.Width > 46340.9499 || r.Length > 46340.9499 || r.Width < 0.0001 || r.Length < 0.0001)
            {
                Console.WriteLine("Стороны прямоугольника вышли за ограничение");
            }
            return razn;
        }


        public override bool Equals(object obj)
        {
            bool equals = true;
            if (obj is Rectangle)
            {
                Rectangle r = (Rectangle)obj;
                equals &= (this.width == r.width) && (this.width == r.width);
            }
            return equals;
        }
    }
}
