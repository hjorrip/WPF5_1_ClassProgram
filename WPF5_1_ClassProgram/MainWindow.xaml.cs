using System;
using System.Collections.Generic;
using System.Data.Entity;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPF5_1_ClassProgram.Models;
using WPF5_1_ClassProgram.Windows;

namespace WPF5_1_ClassProgram
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CollectionViewSource view = new CollectionViewSource();
            SharedContext.dbContext.Classes.Load();
            SharedContext.dbContext.Students.Load();
            SharedContext.Classes = SharedContext.dbContext.Classes.Local;

            view.Source = SharedContext.Classes;
            this.DataContext = view;

        }

        private void menu_QuitClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void menu_NewClassClick(object sender, RoutedEventArgs e)
        {
            NewClassWindow win = new NewClassWindow();
            win.ShowDialog();
        }

        private void menu_NewStudentClick(object sender, RoutedEventArgs e)
        {
            NewStudentWindow win = new NewStudentWindow();
            win.ShowDialog();
        }

        private void menu_ChangeStudentClick(object sender, RoutedEventArgs e)
        {
            ChangeStudentWindow win = new ChangeStudentWindow();
            win.ShowDialog();
        }

        private void lbStudents_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            SharedContext.selectedStudent = (Student)lbStudents.SelectedItem;
        }
    }
}
