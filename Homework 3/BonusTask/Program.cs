Console.WriteLine("Please type a sentence here:");
string sentence = Console.ReadLine();

if (sentence.Contains(" "))
{
    string[] words = sentence.Split(" ");

    string largestWord = "";

    foreach (string word in words)
    {
        if(word.Length > largestWord.Length)
        {
            largestWord = word;
        }
    }
    
    Console.WriteLine($"The largest word in this sentence is: \"{largestWord}\".");
}
else
{
    Console.WriteLine("This is not a sentence!");
}