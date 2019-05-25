using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF5_1_ClassProgram.Models
{
    class ClassDBContext : DbContext
    {
        public DbSet<Class> Classes { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<TypeOfClass> TypeOfClasses { get; set; }
    }
}
