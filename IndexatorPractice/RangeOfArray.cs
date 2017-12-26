using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexatorPractice
{
    public class RangeOfArray
    {
        private object[] array;
        private int size;
        private int start;
        private int end;

        public int Size
        {
            get { return size; }
            set { size = value; }
        }

        public int Start
        {
            get { return start; }
            set { start = value; }
        }

        public int End
        {
            get { return end; }
            set { end = value; }
        }

        public RangeOfArray()
        {
            Size = 0;
            array = new object[Size];
        }

        public RangeOfArray(int start, int end)
        {
            Start = start;
            End = end;
            Size = end - start + 1;
            array = new object[Size];
        }

        public object this[int i]
        {
            get { return array[Math.Abs(i) - Math.Abs(Start)]; }
            set { array[Math.Abs(i) - Math.Abs(Start)] = value;}
        }

    }
}
