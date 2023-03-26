
List<int> numbers = new List<int> { 25, 12, 10, 5, 44, 78, 2, 33, 100, 24 };

List<int> squareOfNumbers = numbers.Select(x => x*x).ToList();

foreach (int number in squareOfNumbers)
{
    Console.WriteLine(number);
}