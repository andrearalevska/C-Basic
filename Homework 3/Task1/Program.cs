Console.WriteLine("Enter some text here:");
string someText = Console.ReadLine();

if (someText.Length > 5)
{
    string lastFiveChars = someText.Substring(someText.Length - 5, 5);
    Console.WriteLine($"The last five characters of this string are \"{lastFiveChars}\".");
}
else
{
    Console.WriteLine("Please enter some text with more than 5 characters.");
}