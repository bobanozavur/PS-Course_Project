using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    class ExerciseContext : DbContext
    {

        public DbSet<Subject> Subjects { get; set; }
        public DbSet<StudentSubject> StudentSubjects { get; set; }
        public ExerciseContext() : base(Properties.Settings.Default.DbConnect)
        { }
    }
}
