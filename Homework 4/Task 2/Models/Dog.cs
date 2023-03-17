
using System.Security.Cryptography.X509Certificates;

namespace Task_2.Models
{
    public class Dog
    {
        public string Name { get; set; }
        public string Breed { get; set; }
        public string Color { get; set; }


        public Dog()
        {

        }

        public Dog(string name, string breed, string color)
        {
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine($"Invalid value for name");
                Name = "Unknown";
            }
            else
            {
                Name = name;
            }
            if (string.IsNullOrEmpty(breed))
            {
                Console.WriteLine($"Invalid value for breed");
                Breed = "Unknown";
            }
            else
            {
                Breed = breed;
            }
            if (string.IsNullOrEmpty(color))
            {
                Console.WriteLine($"Invalid input for color");
                Color = "Unknown";
            }
            else
            {
                Color = color;
            }
        }

        public void Eat()
        {
            Console.WriteLine($"The dog name is {Name}. It is {Color} dog of a breed {Breed}. At the moment {Name} is eating.");
        }

        public void Play()
        {
            Console.WriteLine($"The dog name is {Name}. It is {Color} dog of a breed {Breed}. At the moment {Name} is playing outside.");
        }

        public void ChaseTail()
        {
            Console.WriteLine($"The dog name is {Name}. It is {Color} dog of a breed {Breed}. At the moment {Name} is chasing its tail.");
        }
    }
}
