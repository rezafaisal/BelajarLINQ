using Grouping_02;

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

var query1 = from s in GetStudentList()
             group s by s.FacultyId into g
             select g;

foreach (var g in query1)
{
    Console.WriteLine($"Fakultas: {g.Key}");
    foreach (var s in g)
    {
        Console.WriteLine($"{s.StudentId} {s.StudentName}");
    }
}
