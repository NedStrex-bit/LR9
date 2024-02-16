using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Laba9
{
    public class RectangleArray
    {
        static int count = 0;
        static Random rnd = new Random();
        Rectangle[] array;
        public int Length
        {
            get => array.Length;
        }
        public RectangleArray(int length)
        {
            array = new Rectangle[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = new Rectangle(rnd.Next(10000),rnd.Next(10000));
                count ++;
            }
        }
        public RectangleArray(RectangleArray other)
        {
            this.array = new Rectangle[other.Length];
            for (int i = 0; i < other.Length; i++)
                this.array[i] = new Rectangle(other.array[i]);
        }
        public Rectangle this[int index]
        {
            get
            {
                if (index >= 0 && index < array.Length)
                    return array[index];
                else
                    throw new IndexOutOfRangeException("Индекс выходит за пределы коллекции ");
            }
            set
            {
                if (index >= 0 && index < array.Length)
                    array[index] = value;
            }
        }
        public static int GetCount() { return count; }
        public void Show()
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i].Show();
            }
        }
    }
}
