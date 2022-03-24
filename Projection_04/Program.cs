using Projection_04;

int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

var query1 = from n in numbers
              where n < 5
              select n;

foreach (var num in query1)
{
    Console.WriteLine(num);
}
Console.WriteLine("============================");

static List<Student> GetStudentList()
{
    List<Student> list = new List<Student>();
    list.Add(new Student
    {
        StudentId = 1,
        FacultyId = 1,
        StudentName = "Budi"
    });
    list.Add(new Student
    {
        StudentId = 2,
        FacultyId = 2,
        StudentName = "Wati"
    });
    list.Add(new Student
    {
        StudentId = 3,
        FacultyId = 1,
        StudentName = "Iwan"
    });

    return list;
}

var query2 = from s in GetStudentList()
             where s.FacultyId == 1
             select s;

foreach (var s in query2)
{
    Console.WriteLine($"{s.StudentId}  {s.FacultyId} {s.StudentName}");
}
Console.WriteLine("============================");

int[] numbersA = { 0, 2 };
int[] numbersB = { 1, 3 };

var query3 = from a in numbersA
             from b in numbersB
             select (a, b);

foreach (var pair in query3)
{
    Console.WriteLine($"{pair.a} - {pair.b}");
}
Console.WriteLine("============================");

int[] numbers_a = { 0, 2, 4, 5, 6, 8, 9 };
int[] numbers_b = { 1, 3, 5, 7, 8 };

var query4 = from a in numbers_a
             from b in numbers_b
             where a < b
             select (a, b);

foreach (var pair in query4)
{
    Console.WriteLine($"{pair.a} < {pair.b}");
}
Console.WriteLine("============================");