Console.WriteLine("Enter number here:");
string input = Console.ReadLine();

int num;
bool success = int.TryParse(input, out num);

int SumOfDigits (int number)
{
    int sum = 0;
   
    while(number > 0)
    {
        sum += number % 10;
        number = number / 10;
    }
    return sum;
}

Console.WriteLine($"Sum of digits: {SumOfDigits(num)}");
