int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2 };

var query1 = from n in numbers
             group n by n % 2 into g
             select g;

foreach (var group in query1)
{
    if (group.Key.Equals(0))
    {
        Console.WriteLine("Bilangan Genap:");
    } else
    {
        Console.WriteLine("Bilangan Ganjil");
    }
    
    foreach (var number in group)
    {
        Console.WriteLine(number);
    }
}
Console.WriteLine("===============");

string[] words = { "blueberry", "chimpanzee", "abacus", "banana", "apple", "cheese" };

var query2 = from w in words
                 group w by w[0] into g
                 select (FirstLetter: g.Key, Words: g);

foreach (var g in query2)
{
    Console.WriteLine("Kelompok '{0}':", g.FirstLetter);
    foreach (var w in g.Words)
    {
        Console.WriteLine(w);
    }
}