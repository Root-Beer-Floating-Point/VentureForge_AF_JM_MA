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
    public partial class ExamineExistingAssets : Window
    {
        public ExamineExistingAssets()
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

        private void RulesDocument_Click(object sender, RoutedEventArgs e)
        {
            new ViewDocument().Show();
            Close();
        }

        private void WeaponList_Click(object sender, RoutedEventArgs e)
        {
            new AssetList().Show();
            Close();
        }

        private void PreMadeCharacters_Click(object sender, RoutedEventArgs e)
        {
            new AssetList().Show();
            Close();
        }
    }
}