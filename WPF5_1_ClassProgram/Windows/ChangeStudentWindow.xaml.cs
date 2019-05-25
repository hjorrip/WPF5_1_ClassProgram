using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WPF5_1_ClassProgram.Models;

namespace WPF5_1_ClassProgram.Windows
{
    /// <summary>
    /// Interaction logic for ChangeStudentWindow.xaml
    /// </summary>
    public partial class ChangeStudentWindow : Window
    {

        Student temp;

        public ChangeStudentWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            temp = new Student();
            temp.FirstName = SharedContext.selectedStudent.FirstName;
            temp.LastName = SharedContext.selectedStudent.LastName;
            temp.DateOfBirth = SharedContext.selectedStudent.DateOfBirth;

            this.DataContext = temp;

            lbClasses.DataContext = SharedContext.Classes;
            lbClasses.SelectedItem = SharedContext.Classes.Where(c => c.Id == SharedContext.selectedStudent.ClassId);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SharedContext.selectedStudent.FirstName = temp.FirstName;
            SharedContext.selectedStudent.LastName = temp.LastName;
            SharedContext.selectedStudent.DateOfBirth = temp.DateOfBirth;
            Class selectedClass = (Class)lbClasses.SelectedItem;
            SharedContext.selectedStudent.ClassId = selectedClass.Id;

            SharedContext.dbContext.SaveChanges();

            this.Close();
        }
    }
}
