
List<int> numbers = new List<int>();
numbers.AddRange(1,6,4,3,2,7,4,9,3,9,1,2,4,5,434,56,3,3,2);
Console.WriteLine("Random numbers in the list:");
foreach (var number in numbers)
{
    Console.WriteLine(number);
}