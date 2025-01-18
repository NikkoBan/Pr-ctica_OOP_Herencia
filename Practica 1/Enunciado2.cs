using System;

abstract class Shape
{
    protected double width;
    protected double height;

    public Shape(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public abstract double CalculateSurface();
}

class Triangle : Shape
{
    public Triangle(double width, double height) : base(width, height) { }

    public override double CalculateSurface()
    {
        return (width * height) / 2;
    }
}

class Rectangle : Shape
{
    public Rectangle(double width, double height) : base(width, height) { }

    public override double CalculateSurface()
    {
        return width * height;
    }
}

class Circle : Shape
{
    public Circle(double radius) : base(radius, radius) { }

    public override double CalculateSurface()
    {
        return Math.PI * Math.Pow(width, 2);
    }
}

class Program
{
    static void Main()
    {
        // Crear una matriz de figuras
        Shape[] shapes = new Shape[]
        {
            new Triangle(10, 5),
            new Rectangle(4, 8),
            new Circle(7)
        };

        // Crear una matriz para las áreas
        double[] areas = new double[shapes.Length];

        // Calcular y almacenar las áreas de cada figura
        for (int i = 0; i < shapes.Length; i++)
        {
            areas[i] = shapes[i].CalculateSurface();
            Console.WriteLine($"Área de la figura {i + 1}: {areas[i]:0.00}");
        }
    }
}

