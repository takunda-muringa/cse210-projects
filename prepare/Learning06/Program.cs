// Program.cs
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to hold shapes
        List<Shape> shapes = new List<Shape>();

        // Add a square, rectangle, and circle to the list
        shapes.Add(new Square("Red", 5));
        shapes.Add(new Rectangle("Blue", 4, 6));
        shapes.Add(new Circle("Green", 3));

        // Iterate through the list of shapes
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.Color}, Area: {shape.GetArea()}");
        }
    }
}
