using Projection_02;

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

var query1 = from s in GetStudentList() select s.StudentId;

foreach (var s in query1)
{
    Console.WriteLine(s);
}
Console.WriteLine("======================");

var query2 = from s in GetStudentList() select s.StudentName;

foreach (var s in query2)
{
    Console.WriteLine(s);
}
Console.WriteLine("======================");

var query3 = from s in GetStudentList() select s.FacultyId;

foreach (var s in query3)
{
    Console.WriteLine(s);
}
Console.WriteLine("======================");

string[] words = { "bANANa", "ManGo", "oRanGE" };

var query4 = from w in words
             select new { 
                 Upper = w.ToUpper(), 
                 Lower = w.ToLower() 
             };

foreach (var ul in query4)
{
    Console.WriteLine($"Uppercase: {ul.Upper}, Lowercase: {ul.Lower}");
}
Console.WriteLine("======================");

var query5 = from s in GetStudentList() 
             select new {
                 Nama = s.StudentName, 
                 Fakultas= s.FacultyId
             };

foreach (var s in query5)
{
    Console.WriteLine(s);
    Console.WriteLine($"{s.Nama}  {s.Fakultas}");
}
Console.WriteLine("======================");

var query6 = from w in words
             select (
                Upper: w.ToUpper(), 
                Lower: w.ToLower()
             );

foreach (var ul in query6)
{
    Console.WriteLine($"Uppercase: {ul.Upper}, Lowercase: {ul.Lower}");
}
Console.WriteLine("======================");

var query7 = from s in GetStudentList() select (Nama: s.StudentName, Fakultas: s.FacultyId);

foreach (var s in query7)
{
    Console.WriteLine(s);
    Console.WriteLine($"{s.Nama}  {s.Fakultas}");
}
