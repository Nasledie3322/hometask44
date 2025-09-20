
List<string> items = new List<string>{ "apple", "banana", "cherry" };
items.Remove("apple");
Console.WriteLine("List after removal:");
foreach (var item in items)
{
    Console.WriteLine(item);
}