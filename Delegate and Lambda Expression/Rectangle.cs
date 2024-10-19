using System;

namespace Delegate_and_Lambda_Expression
{
    public class Rectangle
    {
        public void GetArea(double width, double height)
        {
            Console.WriteLine("Area of rectangle: " + width * height);
        }
        public void GetPerimeter(double width, double height)
        {
            Console.WriteLine("Perimeter of rectangle: " + (2 * (width + height)));
        }
    }
}
