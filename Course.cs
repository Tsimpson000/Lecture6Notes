using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture6Notes
{
    public class Course
    {
        string _courseName;
        string _teacher;
        List<Student> _courseRoster = new List<Student>();

        public Course(string courseName, string teacher)
        {
            _courseName = courseName;
            _teacher = teacher;
        }

        public string CourseName { get => _courseName; set => _courseName = value; }
        public string Teacher { get => _teacher; set => _teacher = value; }
        public List<Student> CourseRoster { get => _courseRoster; }

        //Method

        public void EnrollStudent(Student student)
        {
            _courseRoster.Add(student);
        }
    }

}
