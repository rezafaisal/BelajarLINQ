using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projection_04
{
    public class Student
    {
        public int StudentId { get; set; }
        public int FacultyId { get; set; }
        public string StudentName { get; set; }
    }

    public class Faculty
    {
        public int FacultyId { get; set; }
        public string FacultyName { get; set; }
    }
}
