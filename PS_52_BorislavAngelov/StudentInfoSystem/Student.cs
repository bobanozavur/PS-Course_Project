using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    public class Student
    {
        public int StudentId { get; set; }
        public String Name { get; set; }
        public String Surname { get; set; }
        public String LastName { get; set; }
        public String Faculty { get; set; }
        public String Major { get; set; }
        public String Degree { get; set; }
        public int Status { get; set; }
        public String FacultyNumber { get; set; }
        public int Course { get; set; }
        public int Potok { get; set; }

        public int Group { get; set; }
        public Statuses StatusData { get { return (Statuses)Status; } set{} }

        public Student()
        {
        }

        public Student(string name, string surname, string lastName,
            string faculty, string major, string degree, int status,
            string facultyNumber, int course, int potok, int group)
        {
            Name = name;
            Surname = surname;
            LastName = lastName;
            Faculty = faculty;
            Major = major;
            Degree = degree;
            Status = status;
            FacultyNumber = facultyNumber;
            Course = course;
            Potok = potok;
            Group = group;
        }
    }
}
