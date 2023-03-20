

namespace Homework_5.Models
{
    public class Rectangle : Shape
    {
        public int SideA { get; set; }
        public int SideB { get; set; }  

        public Rectangle(string name, string color, int[] position, int sideA, int sideB) : base(name, color, position)
        {
            SideA = sideA;
            SideB = sideB;
        }

        public override void GetArea()
        {
            Console.WriteLine($"The area of {Name} is {SideA * SideB}");
        }

        public override void GetPerimeter()
        {
            Console.WriteLine($"The perimeter of {Name} is {(2 * SideA) + (2 * SideB)}");
        }
    }
}
 