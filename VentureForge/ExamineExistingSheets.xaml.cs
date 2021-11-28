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
    /// Interaction logic for ExamineExistingSheets.xaml
    /// </summary>
    public partial class ExamineExistingSheets : Window
    {
        public ExamineExistingSheets()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            new ErrorPage().Show();
            Close();
        }

        private void SignIn_Click(object sender, RoutedEventArgs e)
        {
            new ErrorPage().Show();
            Close();
        }

        private void HomePage_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            Close();
        }

        private void PreviousPage_Click(object sender, RoutedEventArgs e)
        {
            new CreateModule().Show();
            Close();
        }

    }
}
