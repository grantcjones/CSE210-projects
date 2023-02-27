using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> myShapes = new List<Shape>();

        Square s1 = new Square("Blue", 4);

        Rectangle r1 = new Rectangle("Green", 6, 4);

        Circle c1 = new Circle("Brown", 6);

        myShapes.Add(s1);
        myShapes.Add(r1);
        myShapes.Add(c1);

        foreach (Shape i in myShapes)
        {
            string color = i.GetColor();
            float area = i.GetArea();

            Console.WriteLine($"Color: {color}, Area: {area}");
        }
    }
}