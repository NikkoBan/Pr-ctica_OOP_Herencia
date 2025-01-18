var shapes = new Shape[]
{
    new Rectangle { Ancho = 5, Alto = 10 },
    new Triangle { Ancho = 6, Alto = 8 },
    new Circle(7)
};

var areas = shapes.Select(shape => shape.CalculateSurface()).ToArray();

foreach (var area in areas)
{
    Console.WriteLine($"Área: {area:F2}");
}
