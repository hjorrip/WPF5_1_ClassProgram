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
    /// Interaction logic for NewStudentWindow.xaml
    /// </summary>
    public partial class NewStudentWindow : Window
    {

        Student s;


        public NewStudentWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            s = new Student();
            this.DataContext = s;
            lbClasses.DataContext = SharedContext.Classes;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Class selectedClass = (Class)lbClasses.SelectedItem;

            s.ClassId = selectedClass.Id;

            SharedContext.dbContext.Students.Add(s);
            SharedContext.dbContext.SaveChanges();
            this.Close();
        }
    }
}
