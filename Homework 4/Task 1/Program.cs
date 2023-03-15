Console.WriteLine("Enter your date of birth:");
string input = Console.ReadLine();

AgeCalculator(input);

int AgeCalculator (string birthday)
{
    DateTime birthdayDate;
    bool success = DateTime.TryParse(birthday, out birthdayDate);
    if (success == false)
    {
        Console.WriteLine("Please enter your birth date only!");
        return 0;
    }

    int birthdayYear = birthdayDate.Year;
    DateTime today = DateTime.Now;
    int currentYear = today.Year;
    int age = currentYear - birthdayYear;

    if ((birthdayDate.Month > today.Month) || (birthdayDate.Month == today.Month && birthdayDate.Day > today.Day))
    {
        Console.WriteLine($"You are {age - 1} years old");
    }
    else
    {
        Console.WriteLine($"You are {age} years old");
    }
    return age; 
}


