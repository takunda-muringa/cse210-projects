// Shape.cs
public class Shape
{
    public string Color { get; set; }

    public Shape(string color)
    {
        Color = color;
    }

    public virtual double GetArea()
    {
        // This will be overridden in derived classes
        return 0;
    }
}
