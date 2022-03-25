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