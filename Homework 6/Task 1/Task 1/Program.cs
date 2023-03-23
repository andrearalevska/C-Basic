Queue<int> numbers = new Queue<int>();
string input;

do
{
    Console.WriteLine("Input number:");
    string numberInput = Console.ReadLine();

    int number;
    bool success = int.TryParse(numberInput, out number);

    if (success)
    {
        numbers.Enqueue(number);
    }

    else
    {
        Console.WriteLine("Please insert only numbers.");
    }
    Console.WriteLine("If you want to add another number type Y, else type N");
    input = Console.ReadLine();

    if (input.ToLower() == "n")
    {
        Console.WriteLine("Your numbers are:");
        foreach(int num in numbers)
        {
            Console.WriteLine($"{num}");
        }
    }
    else if (string.IsNullOrEmpty(input) || input.ToLower() != "y")
    {
        Console.WriteLine("Error you did not enter Y for \"yes\" or N for \"no\".");
    }
}

while (input.ToLower() == "y");
