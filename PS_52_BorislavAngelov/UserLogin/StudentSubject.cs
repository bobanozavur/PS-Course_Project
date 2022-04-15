using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    public class StudentSubject
    {
        public int StudentSubjectId { get; set; }
        public int Subject1 { get; set; }
        public int Subject2 { get; set; }

        public int Subject3 { get; set; }

        public StudentSubject(int subject1, int subject2, int subject3)
        {
            Subject1 = subject1;
            Subject2 = subject2;
            Subject3 = subject3;
        }

        public StudentSubject()
        {
        }
    }
}
