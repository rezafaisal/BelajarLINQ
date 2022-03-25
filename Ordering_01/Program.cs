string[] words = { "cherry", "apple", "blueberry" };

var query1 = from word in words
                  orderby word
                  select word;

foreach (var w in query1)
{
    Console.WriteLine(w);
}
Console.WriteLine("=========================");

int[] numbers = { 5, 3, 1, 11, 7, 4};

var query2 = from number in numbers
             orderby number
             select number;

foreach (var n in query2)
{
    Console.WriteLine(n);
}
Console.WriteLine("=========================");

var query3 = from word in words
                  orderby word.Length
                  select word;

foreach (var w in query3)
{
    Console.WriteLine(w);
}
Console.WriteLine("=========================");

var query4 = from word in words
             orderby word descending
             select word;

foreach (var w in query4)
{
    Console.WriteLine(w);
}