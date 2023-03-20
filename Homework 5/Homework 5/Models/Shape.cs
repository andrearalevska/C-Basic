
using System.Reflection.Metadata;

namespace Homework_5.Models
{
    public class Shape
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int[] Position { get; set; }

        public Shape(string name, string color, int[] position)
        {
            Name = name;
            Color = color;
            Position = position;
        }

        public virtual void GetArea()
        {
            Console.WriteLine("There is no special implementation for area");
        }

        public virtual void GetPerimeter()
        {
            Console.WriteLine("There is no special implementation for perimeter");
        }

        public void Move(Shape shape)
        {
            shape.Position[0] += 5;
            shape.Position[1] += 5;
            Console.WriteLine($"The new coordinates are x: {shape.Position[0]}, y: {shape.Position[1]}");
        }

        public void GetName()
        {
            Console.WriteLine($"Shape: {Name}");
        }

        public void GetColor()
        {
            Console.WriteLine($"Shape: {Color}");
        }

        public string SetName(string newName)
        {
            if (string.IsNullOrEmpty(newName))
            {
                Console.WriteLine("Invalid input for name");
                return Name = "Unknown";
            }
            else
            {
                Console.WriteLine($"New name is {newName}");
                return Name = newName;
            }
        }
        public string SetColor(string newColor)
        {
            if (string.IsNullOrEmpty(newColor))
            {
                Console.WriteLine("Invalid input for color");
                return Color = "Unknown";
            }
            else
            {
                Console.WriteLine($"New color is {newColor}");
                return Color = newColor;

            }
        }
    }
}