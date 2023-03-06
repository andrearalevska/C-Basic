Console.WriteLine("Input first number");
string firstInput = Console.ReadLine();

int firstNumber;
bool firstSuccess = int.TryParse(firstInput, out firstNumber);

Console.WriteLine("Input second number");
string secondInput = Console.ReadLine();

int secondNumber;
bool secondSuccess = int.TryParse(secondInput, out secondNumber);

if(firstSuccess == true  && secondSuccess == true)
{
    int anotherFirstNum = firstNumber;
    firstNumber = secondNumber;
    secondNumber = anotherFirstNum;

    Console.WriteLine("First number now is: " + firstNumber);
    Console.WriteLine("Second number now is: " + secondNumber);
}

else
{
    Console.WriteLine("Invalid inputs, please enter numbers only!");
}