using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace StudentInfoSystem.ViewModel
{
    public class StudentsByGroupsVM : ObservableObject
    {
        public ObservableCollection<Student> _students = new ObservableCollection<Student>();

        public IEnumerable<Student> Students49
        {
            get
            {
                StudentInfoContext context = new StudentInfoContext();


                _students = new ObservableCollection<Student>(from st in context.Students where st.Group == 49 select st);
                return _students;
            }
        }
        public IEnumerable<Student> Students50
        {
            get
            {
                StudentInfoContext context = new StudentInfoContext();


                _students = new ObservableCollection<Student>(from st in context.Students where st.Group == 50 select st);
                return _students;
            }
        }
        public IEnumerable<Student> Students51
        {
            get
            {
                StudentInfoContext context = new StudentInfoContext();


                _students = new ObservableCollection<Student>(from st in context.Students where st.Group == 51 select st);
                return _students;
            }
        }
        public IEnumerable<Student> Students52
        {
            get
            {
                StudentInfoContext context = new StudentInfoContext();


                _students = new ObservableCollection<Student>(from st in context.Students where st.Group == 52 select st);
                return _students;
            }
        }
        public IEnumerable<Student> Students53
        {
            get
            {
                StudentInfoContext context = new StudentInfoContext();


                _students = new ObservableCollection<Student>(from st in context.Students where st.Group == 53 select st);
                return _students;
            }


        }

   

    }
}
