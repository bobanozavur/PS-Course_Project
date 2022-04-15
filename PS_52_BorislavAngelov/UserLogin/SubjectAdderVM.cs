using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace StudentInfoSystem
{
    public class SubjectAdderVM : ObservableObject
    {
        private string _subject;
        private StudentInfoContext context = new StudentInfoContext();
        public string Subject
        {
            get { return _subject; }
            set
            {
                _subject = value;
                RaisePropertyChangedEvent("Subject");
            }
        }
        public ICommand AddSubjectCommand
        {
            get { return new DelegateCommand(AddSubject); }
        }
        private void AddSubject()
        {
                  ExerciseContext context = new ExerciseContext();
            string sub = Subject;
            context.Subjects.Add(new Subject(sub));
            context.SaveChanges();

        }
}
}
