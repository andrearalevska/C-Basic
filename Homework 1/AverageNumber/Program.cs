Console.WriteLine("Enter first number:");
string firstInput =  Console.ReadLine();

int firstNumber;
bool firstSuccess = int.TryParse(firstInput, out firstNumber);

Console.WriteLine("Enter second number:");
string secondInput = Console.ReadLine();

int secondNumber;
bool secondSuccess = int.TryParse(secondInput, out secondNumber);

Console.WriteLine("Enter third number:");
string thirdInput = Console.ReadLine();

int thirdNumber;
bool thirdSuccess = int.TryParse(thirdInput, out thirdNumber);

Console.WriteLine("Enter fourth number:");
string fourthInput = Console.ReadLine();

int fourthNumber;
bool fourthSuccess = int.TryParse(fourthInput, out fourthNumber);

if(firstSuccess == true && secondSuccess == true && thirdSuccess == true && fourthSuccess == true)
{
    int result = (firstNumber + secondNumber + thirdNumber + fourthNumber) / 4;
    Console.WriteLine("The average number is:" + result);
}

else
{
    Console.WriteLine("Please enter only numbers!!");
}



