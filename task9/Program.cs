
List<int> numbers = new List<int>();
numbers.AddRange(1, 2, 3, 4, 5, 6, 7);
Console.WriteLine("All numbers in the list:");
foreach (var number in numbers)
{
    Console.WriteLine(number);
}