using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF5_1_ClassProgram.Models
{
    class SharedContext
    {

        public static ClassDBContext dbContext = new ClassDBContext();

        public static ObservableCollection<Class> Classes = new ObservableCollection<Class>();
        public static ObservableCollection<Student> Students = new ObservableCollection<Student>();
        public static Student selectedStudent = new Student();
    }
}
