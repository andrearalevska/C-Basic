using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5.Models
{
    public class Circle : Shape
    {
        public int Radius { get; set; }

        public Circle(string name, string color, int[] position, int radius) : base(name, color, position)
        {
            Radius = radius;
        }

        public override void GetArea()
        {
            Console.WriteLine($"The area of {Name} is {3.14159 * (Radius * Radius)}");
        }

        public override void GetPerimeter()
        {
            Console.WriteLine($"The perimeter of {Name} is {2 * 3.14159 * Radius}");
        }
    }
}
