using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF5_1_ClassProgram.Models
{
    class Class
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public TypeOfClass TypeOfClass { get; set; }
        public ObservableCollection<Student> Students { get; set; }

        public Class()
        {
            Students = new ObservableCollection<Student>();
        }

    }
}
