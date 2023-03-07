Console.WriteLine("Enter first integer:");
string firstInput = Console.ReadLine();

int firstNumber;
bool firstSuccess = int.TryParse(firstInput, out firstNumber);

Console.WriteLine("Enter second integer:");
string secondInput = Console.ReadLine();

int secondNumber;
bool secondSuccess = int.TryParse(secondInput, out secondNumber);

Console.WriteLine("Enter third integer:");
string thirdInput = Console.ReadLine();

int thirdNumber;
bool thirdSuccess = int.TryParse(thirdInput, out thirdNumber);

Console.WriteLine("Enter fourth integer:");
string fourthInput = Console.ReadLine();

int fourthNumber;
bool fourthSuccess = int.TryParse(fourthInput, out fourthNumber);

Console.WriteLine("Enter fifth integer:");
string fifthInput = Console.ReadLine();

int fifthNumber;
bool fifthSuccess = int.TryParse(fifthInput, out fifthNumber);

Console.WriteLine("Enter sixth integer:");
string sixthInput = Console.ReadLine();

int sixthNumber;
bool sixthSuccess = int.TryParse(sixthInput, out sixthNumber);


if (firstSuccess == true && secondSuccess == true && thirdSuccess == true && fourthSuccess == true && fifthSuccess == true && sixthSuccess == true)
{
    int[] arrayOfIntegers = new int[] { firstNumber, secondNumber, thirdNumber, fourthNumber, fifthNumber, sixthNumber };

    int sum = 0;

    for (int i = 0; i < arrayOfIntegers.Length; i++)
    {
        if (arrayOfIntegers[i] % 2 == 0)
        {
            sum += arrayOfIntegers[i];
        }
    }

    Console.WriteLine("The sum of the even integers in this array is: " + sum);
}

else
{
    Console.WriteLine("Please enter only integer!");
}


