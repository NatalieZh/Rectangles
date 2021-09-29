using System;
using System.Collections.Generic;
using System.Text;

namespace Rectangles
{
    class ArrayRectangles
    {
        private Rectangle[] rectangleArray;

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

        public int NumberMaxArea()
        {
            int result = -1;

            return result;
        }

    }
}
