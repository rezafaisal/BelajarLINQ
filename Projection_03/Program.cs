using Projection_03;

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

var query1 = from s in GetStudentList() select s;

foreach (var s in query1)
{
    Console.WriteLine($"{s.StudentId}  {s.FacultyId} {s.StudentName}");
}
Console.WriteLine("========================");

var query2 = from s in GetStudentList() 
             select (s.StudentId, s.StudentName, s.FacultyId);

foreach (var s in query2)
{
    Console.WriteLine($"{s.StudentId} {s.FacultyId} {s.StudentName}");
}
Console.WriteLine("========================");

var query3 = from s in GetStudentList() 
             select (
                s.StudentId, 
                s.StudentName
             );

foreach (var s in query3)
{
    Console.WriteLine($"{s.StudentId}  {s.StudentName}");
}
Console.WriteLine("========================");

var query4 = from s in GetStudentList()
             select (
                Fakultas : s.FacultyId,
                s.StudentName
             );

foreach (var s in query4)
{
    Console.WriteLine($"{s.Fakultas}  {s.StudentName}");
}
Console.WriteLine("========================");
