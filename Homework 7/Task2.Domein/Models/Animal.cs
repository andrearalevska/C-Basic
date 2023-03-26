
using Task2.Domein.Enums;

namespace Task2.Domein.Models
{
    public class Animal
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }

        public Animal(string name, string color, int age, Gender gender) 
        {
            Name = name;
            Color = color;
            Age = age;
            Gender = gender;
        }
    }
}
