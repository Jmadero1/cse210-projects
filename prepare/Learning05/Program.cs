// Program.cs
using System;
using System.Collections.Generic;
using Learning05.Models; 

namespace Learning05
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();

            
            shapes.Add(new Square("white", 5));
            shapes.Add(new Rectangle("Black", 4, 6));
            shapes.Add(new Circle("blue", 3));

            
            foreach (Shape shape in shapes)
            {
                
                Console.WriteLine($"Color: {shape.GetColor()}, Área: {shape.GetArea()}");
            }
        }
    }
}
