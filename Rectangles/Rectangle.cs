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
        public Rectangle()
        {
            sideA = 4;
            sideB = 3;
        }

        int GetSideA()
        {
            return sideA;
        }

        int GetSideB()
        {
            return sideB;
        }

        double Area()
        {
            return sideA * sideB;
        }

        double Perimeter()
        {
            return sideA + sideB;
        }

        bool IsSquare()
        {
            return sideA == sideB;
        }

        void ReplaceSides()
        {
            int temp = sideA;
            sideA = sideB;
            sideB = temp;
        }
    }
}
