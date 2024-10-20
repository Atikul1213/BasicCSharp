namespace MulticastDelegate
{
    public class Rectangle
    {
        public void GetArea(double Width, double Height)
        {
            Console.WriteLine($"Area is {Width * Height}");
        }
        public void GetPerimeter(double Width, double Height)
        {
            Console.WriteLine($"Perimeter is {2 * (Width + Height)}");
        }
    }
}
