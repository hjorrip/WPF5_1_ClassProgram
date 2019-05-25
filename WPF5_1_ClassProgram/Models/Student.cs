using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF5_1_ClassProgram.Models
{
    class Student : INotifyPropertyChanged
    {
        public int Id { get; set; }

        private string _firstName;
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
                NotifyPropertyChanged("FullName");
            }
        }


        private string _lastName;
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
                NotifyPropertyChanged("FullName");
            }
        }



        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        public DateTime DateOfBirth { get; set; }

        public int ClassId { get; set; }

        public Student()
        {
            DateOfBirth = DateTime.Now;
        }


        private void NotifyPropertyChanged(string PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
