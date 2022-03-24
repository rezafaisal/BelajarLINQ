int[] numbers = { 13, 4, 11, 3, 9, 8, 6, 7, 2, 0 };

var query1 = from n in numbers 
             select n + 1;

Console.WriteLine("Bilangan + 1:");
foreach (var i in query1)
{
    Console.WriteLine(i);
}
Console.WriteLine("========================");

string words = "i am studying C# programming language";
var query2 = from word in words.Split(" ") 
             select "kata: " + word;

foreach (var word in query2)
{
    Console.WriteLine(word);
}
Console.WriteLine("========================");

int[] index = { 0, 1, 2, 3, 4 };
string[] strings = { "zero", "one", "two", "three", "four", "five", "six" };

var query3 = from n in index
               select strings[n];

foreach (var s in query3)
{
    Console.WriteLine(s);
}