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

namespace VentureForge
{
    /// <summary>
    /// Interaction logic for ExamineExistingAssests.xaml
    /// </summary>
    public partial class ExamineExistingAssests : Window
    {
        public ExamineExistingAssests()
        {
            InitializeComponent();
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            Close();
        }

        private void PreviousPage_Click(object sender, RoutedEventArgs e)
        {
            new CreateModule().Show();
            Close();
        }

        private void SignIn_Click(object sender, RoutedEventArgs e)
        {
            new ErrorPage().Show();
            Close();

        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            new ErrorPage().Show();
            Close();
        }
    }
}
