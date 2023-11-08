using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapeList = new List<Shape>();


        Square eesSquare = new Square("red", 5);
        Console.WriteLine(eesSquare.GetColor());
        eesSquare.SetColor("blue");
        Console.WriteLine(eesSquare.GetColor());
        shapeList.Add(eesSquare);
        Console.WriteLine($"the area of the sqaure is: {eesSquare.GetArea()}");

        Rectangle eesRectangle = new Rectangle("Green", 4, 2);
        shapeList.Add(eesRectangle);
        Console.WriteLine($"The area of the rectangle is {eesRectangle.GetArea()}. ");

        Circle eesCircle = new Circle("Purple", 3);
        shapeList.Add(eesCircle);
        Console.WriteLine($"The area of the circle is {eesCircle.GetArea()}. ");

        Console.WriteLine("\n In the List: ");
        foreach (Shape shape in shapeList){
            Console.WriteLine(shape.GetColor());
            Console.WriteLine($"The area of the circle is {shape.GetArea()}. ");

        }
    }
}