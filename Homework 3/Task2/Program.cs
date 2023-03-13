using System.Diagnostics.Metrics;

Console.WriteLine("Please type a sentence here:");
string sentence = Console.ReadLine();

if(sentence.Contains(" "))
{
    string[] words = sentence.Split(" ");
    int counter = 1;

    Console.WriteLine("List of words in your sentence:");
    foreach(string word in words)
    {
        Console.WriteLine($"{counter}. {word}");
        counter++;
    }
}
else
{
    Console.WriteLine("Try again, this input is not a sentence.");
}