Console.WriteLine("Enter first number:");
string firstInput = Console.ReadLine();

double firstNumber;
bool firstSuccess = double.TryParse(firstInput, out firstNumber);

Console.WriteLine("Enter second number:");
string secondInput = Console.ReadLine();

double secondNumber;
bool secondSuccess = double.TryParse(secondInput, out secondNumber);

if(firstSuccess == false || secondSuccess == false)
{
    Console.WriteLine("Please enter a number!!!");
}

else
{
    Console.WriteLine("Choose math operation (+, -, *, /):");
    string operation = Console.ReadLine();

    if (operation == "+")
    {
        double sum = firstNumber + secondNumber;
        Console.WriteLine(sum);
    }

    else if (operation == "-")
    {
        double difference = firstNumber - secondNumber;
        Console.WriteLine(difference);
    }

    else if (operation == "*")
    {
        double product = firstNumber * secondNumber;
        Console.WriteLine(product);
    }

    else if (operation == "/")
    {
        double quotient = firstNumber / secondNumber;
        Console.WriteLine(quotient);
    }

    else
    {
        Console.WriteLine("Please enter valid operation!");
    }

}




