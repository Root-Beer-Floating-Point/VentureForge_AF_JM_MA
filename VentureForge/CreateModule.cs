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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class CreateModule : Window
    {
        public CreateModule()
        {
            InitializeComponent();
        }
        private void UploadAssests_Click(object sender, RoutedEventArgs e)
        {
            new UploadAssests().Show();
        }

        private void ExamineAssets_Click(object sender, RoutedEventArgs e)
        {
            new ExamineExistingAssests().Show();
        }

        private void CreateSheets_Click(object sender, RoutedEventArgs e)
        {
            new CreateSheets().Show();
        }

        private void ExamineSheets_Click(object sender, RoutedEventArgs e)
        {
            new ExamineExistingSheets().Show();
        }

        private void UploadModule_Click(object sender, RoutedEventArgs e)
        {
            new UploadeModule().Show();
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
        }

        private void SginIn_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Login_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
