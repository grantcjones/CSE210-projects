using System;
using static System.Console;

public class Circle : Shape
{
    private float _radius;
    const float PI = (float)Math.PI;

    public Circle(string color, float radius) : base (color)
    {
        _radius = radius;
    }

    public override float GetArea()
    {
        return _radius * _radius * PI;
    }

    public void Display()
    {
        WriteLine($"Color: {GetColor()}, Area: {GetArea()}");
    }
}