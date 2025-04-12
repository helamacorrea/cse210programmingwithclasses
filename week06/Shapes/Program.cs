using System;

class Program
{
    static void Main(string[] args)
    {
        Square square1 = new Square("white", 30);
        Console.WriteLine(square1.GetArea());
        Rectangle rec1 = new Rectangle("purple", 20, 10);
        Console.WriteLine(rec1.GetArea());
        Circle cir1 = new Circle("black", 4.5);
        Console.WriteLine(cir1.GetArea());


        List<Shapes> shapesList = new List<Shapes>();
        shapesList.Add(square1);
        shapesList.Add(rec1);
        shapesList.Add(cir1);

        foreach (Shapes shape in shapesList)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
        
        
    }
}