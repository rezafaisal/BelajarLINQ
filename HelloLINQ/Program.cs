// See https://aka.ms/new-console-template for more information
using HelloLINQ;

int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

var q1 = from number in numbers select number;
foreach (var number in q1)
{
    Console.Write($"{number} ");
}

string words = "i am studying C# programming language";
var query = from word in words.Split(" ") select word;

foreach(var word in query)
{
    Console.WriteLine(word);
}

static List<Student> GetStudentList()
{
    List<Student> list = new List<Student>();
    list.Add(new Student { 
        StudentId = 1, 
        FacultyId = 1, 
        StudentName = "Budi" 
    });
    list.Add(new Student { 
        StudentId = 2, 
        FacultyId = 2, 
        StudentName = "Wati" 
    });
    list.Add(new Student { 
        StudentId = 3, 
        FacultyId = 1, 
        StudentName = "Iwan" 
    });

    return list;
}

var queryStudent = from s in GetStudentList() select s;

foreach (var s in queryStudent)
{
    Console.WriteLine($"{s.StudentId} {s.FacultyId} {s.StudentName}");
}

static List<Faculty> GetFacultyList()
{
    List<Faculty> list = new List<Faculty>();
    list.Add(new Faculty { 
        FacultyId = 1, 
        FacultyName = "Computer Science" 
    });
    list.Add(new Faculty { 
        FacultyId = 2, 
        FacultyName = "Mathematics" 
    });
    list.Add(new Faculty { 
        FacultyId = 3, 
        FacultyName = "Physics" 
    });

    return list;
}

var queryFaculty = from faculty in GetFacultyList() select faculty;

foreach (var s in queryFaculty)
{
    Console.WriteLine($"{s.FacultyId} {s.FacultyName} ");
}