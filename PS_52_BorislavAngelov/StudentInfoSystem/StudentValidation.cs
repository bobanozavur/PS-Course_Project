using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserLogin;

namespace StudentInfoSystem
{
    class StudentValidation
    {
        public Student GetStudentDataByUser(User user) { 
        
            try{
                StudentInfoContext context = new StudentInfoContext();
                Student s = (from num in context.Students 
                         where num.FacultyNumber.Contains(user.FakNum) 
                         select num).First();
                return s;
            }            catch(System.InvalidOperationException e)
            {
                return null;
            }
        }
    }
}
