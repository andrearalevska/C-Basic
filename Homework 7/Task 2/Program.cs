using System.Runtime.CompilerServices;
using Task2.Domein.Enums;
using Task2.Domein.Models;

List<Animal> animals = new List<Animal>()
    {
        new Animal("Lana", "brown", 3, Gender.Female),
        new Animal("Cleopatra", "black", 5, Gender.Female),
        new Animal("Jose-Rodrigues", "brown", 7, Gender.Male),
        new Animal("Astra", "black & yellow", 2, Gender.Female),
        new Animal("Apolo", "brown", 10, Gender.Male),
        new Animal("Cameroon", "brown", 1, Gender.Male),
        new Animal("Agatha", "green", 25, Gender.Female),
        new Animal("Shmitz", "white", 9, Gender.Male),
        new Animal("Aria", "black", 2, Gender.Female),
    };

List<Animal> agedFiveOrMore = animals.Where(x => x.Age >= 5).ToList();
Console.WriteLine("Animals older than 5 years:");
foreach (Animal animal in agedFiveOrMore)
{
    Console.WriteLine(animal.Name );
}

List<Animal> nameStartsWithA = animals.Where (x => x.Name.StartsWith("A")).ToList();
Console.WriteLine("Animals whose name starts with \"A\":");
foreach(Animal animal in nameStartsWithA)
{
    Console.WriteLine(animal.Name);
}

List<Animal> maleAndBrown = animals.Where(x => x.Gender == Gender.Male && x.Color == "brown").ToList();
Console.WriteLine("Animals that are male and brown:");
foreach(Animal animal in maleAndBrown)
{
    Console.WriteLine(animal.Name);
}

Animal moreThenTenChars = animals.FirstOrDefault(x => x.Name.Length > 10);
if (moreThenTenChars != null);
{
    Console.WriteLine($"The first animal whose name has more than 10 characters is: {moreThenTenChars.Name}.");
}






