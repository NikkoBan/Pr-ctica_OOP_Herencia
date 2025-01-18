// Clase abstracta Shape
public abstract class Shape
{
    public double Ancho { get; set; }
    public double Alto { get; set; }

    public abstract double CalculateSurface();
}

// Clase Rectangle
public class Rectangle : Shape
{
    public override double CalculateSurface()
    {
        return Ancho * Alto;
    }
}

// Clase Triangle
public class Triangle : Shape
{
    public override double CalculateSurface()
    {
        return (Ancho * Alto) / 2;
    }
}

// Clase Circle
public class Circle : Shape
{
    public Circle(double radio)
    {
        Ancho = radio;
        Alto = radio;
    }

    public override double CalculateSurface()
    {
        return Math.PI * Math.Pow(Alto, 2);
    }
}
