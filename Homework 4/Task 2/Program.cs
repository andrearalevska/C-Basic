using Task_2.Models;

Dog dog = new Dog();

Console.WriteLine("Enter the name of the dog here:");
dog.Name = Console.ReadLine();

Console.WriteLine("Enter the breed of the dog here:");
dog.Breed = Console.ReadLine();

Console.WriteLine("Enter the color of the dog here:");
dog.Color = Console.ReadLine();

Console.WriteLine("Now choose what you want your dog to do: Type 1 for eating, 2 for playing and 3 for chaising tail.");
string choise =  Console.ReadLine();

if(choise == "1")
{
    dog.Eat();
}
else if(choise == "2")
{
    dog.Play();
}
else if(choise == "3")
{
    dog.ChaseTail();
}
else
{
    Console.WriteLine("Invalid option, choose 1,2 or 3");
}