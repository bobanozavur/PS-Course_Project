using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    class StudentData
    {
        private static List<Student> _testStudents = new List<Student>();
        public static List<Student> TestStudents { get {
                if (!_testStudents.Any())
                {
                    _testStudents.Add(new Student("Jerry", "Jamison", "Joestar", "FKST", "KSI", "bachelor", 0, "121218680",3, 1, 49));
                }
                return _testStudents;
            } private set
            {
                _testStudents = value;
            }
        }
    }
}
