namespace Firgures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Figure circle = new Circle(5);
            Figure rectangle = new Rectangle(3, 7);
            Console.WriteLine($"Circle perimeter: {circle.calculatePerimeter()}");
            Console.WriteLine($"Circle area: {circle.calculateArea()}");
            Console.WriteLine(circle.Draw());
            Console.WriteLine($"Rectangle perimeter: {rectangle.calculatePerimeter()}");
            Console.WriteLine($"Rectangle area: {rectangle.calculateArea()}");
            Console.WriteLine(rectangle.Draw());
        }
    }
}
