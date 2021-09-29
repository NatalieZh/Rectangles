using System;
using System.Collections.Generic;
using System.Text;

namespace Rectangles
{
    class Rectangle
    {
        private int _sideA, _sideB;

        public int sideA
        {
            get { return _sideA; }
            set { _sideA = value; }
        }
        public int sideB
        {
            get { return _sideB; }
            set { _sideB = value; }
        }

        public Rectangle(int a, int b)
        {
            sideA = a < 1 ? 0 : a;
            sideB = b < 1 ? 0 : b;
        }

        public Rectangle(int a)
        {
            sideA = a < 1 ? 0 : a;
            sideB = 5;
        }
        public Rectangle(int b, int? a)
        {
            sideB = b < 1 ? 0 : b;
            if (a.HasValue && a > 0)
            {
                sideA = a.Value;
            }
            else 
            {
                sideA = 0;
            }

        }
        public Rectangle()
        {
            sideA = 4;
            sideB = 3;
        }

        public int GetSideA()
        {
            return sideA;
        }

        public int GetSideB()
        {
            return sideB;
        }

        public double Area()
        {
            return sideA * sideB;
        }

        public double Perimeter()
        {
            return (sideA + sideB)*2;
        }

        public bool IsSquare()
        {
            return sideA == sideB;
        }

        public void ReplaceSides()
        {
            int temp = sideA;
            sideA = sideB;
            sideB = temp;
        }
    }
}
