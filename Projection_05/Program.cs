using Projection_05;

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

static List<Faculty> GetFacultyList()
{
    List<Faculty> list = new List<Faculty>();
    list.Add(new Faculty
    {
        FacultyId = 1,
        FacultyName = "Computer Science"
    });
    list.Add(new Faculty
    {
        FacultyId = 2,
        FacultyName = "Mathematics"
    });
    list.Add(new Faculty
    {
        FacultyId = 3,
        FacultyName = "Physics"
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