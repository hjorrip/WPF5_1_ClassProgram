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
    /// Interaction logic for NewClassWindow.xaml
    /// </summary>
    public partial class NewClassWindow : Window
    {

        Class c;

        public NewClassWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            c = new Class();
            this.DataContext = c;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SharedContext.dbContext.Classes.Add(c);
            SharedContext.dbContext.SaveChanges();
            this.Close();

        }
    }
}
