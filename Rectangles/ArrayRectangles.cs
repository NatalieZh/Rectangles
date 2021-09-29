using System;
using System.Collections.Generic;
using System.Text;

namespace Rectangles
{
    class ArrayRectangles
    {
        private Rectangle[] rectangleArray;
        public int Length {
            get
            {
                return rectangleArray != null ? rectangleArray.Length : 0;
            } 
        }

        public ArrayRectangles(int length)
        {
            rectangleArray = new Rectangle[length];
        }

        public ArrayRectangles(Rectangle[] rectangles)
        {
            rectangleArray = rectangles;
        }

        public bool AddRectangle(Rectangle rectangle)
        {
            bool result = false;
            for (int i = 0; i < rectangleArray.Length; i++)
            {
                if (rectangleArray[i] == null)
                {
                    rectangleArray[i] = rectangle;
                    result = true;
                    break;
                }
            }
            return result;
        }
        public bool DeleteRectangle(int i)
        {
            bool result = false;
            if (i >= 0 && i < rectangleArray.Length)
            {
                rectangleArray[i] = null;
                result = true;
            }


            return result;
        }

        public int NumberMaxArea()
        {
            int result = -1;
            double maxArea = -1;
            for (int i = 0; i < rectangleArray.Length; i++)
            {
                if (rectangleArray[i] != null && rectangleArray[i].Area() > maxArea)
                {
                    maxArea = rectangleArray[i].Area();
                    result = i;
                }
            }
            return result;
        }

        public int NumberMinPerimeter()
        {
            int result = -1;
            double minPerimeter = double.MaxValue;
            for (int i = 0; i < rectangleArray.Length; i++)
            {
                if (rectangleArray[i] != null && rectangleArray[i].Perimeter() < minPerimeter)
                {
                    minPerimeter = rectangleArray[i].Perimeter();
                    result = i;
                }
            }
            return result;
        }

        public int NumberSquare()
        {
            int result = 0;
            for (int i = 0; i < rectangleArray.Length; i++)
            {
                if (rectangleArray[i] != null && rectangleArray[i].IsSquare())
                {
                    result++;
                }
            }
            return result;
        }

        public string GetInfo()
        {
            string result = string.Empty;
            for (int i = 0; i < rectangleArray.Length; i++)
            {
                if (rectangleArray[i] == null)
                {
                    result += $"Rectangle{i}: nothing\n";
                }
                else
                {
                    result += $"Rectangle{i}: SideA:{rectangleArray[i].sideA}, SideB:{rectangleArray[i].sideB}, Area:{rectangleArray[i].Area()}, Perimeter:{rectangleArray[i].Perimeter()}\n";
                }
            }
            result += $"\nSquares:{NumberSquare()}, NumberMinPerimeter:{NumberMinPerimeter()}, NumberMaxArea:{NumberMaxArea()}";
            return result;
        }

    }
}
