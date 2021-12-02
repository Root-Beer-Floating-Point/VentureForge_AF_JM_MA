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
    public partial class UseModule : Window
    {
        public UseModule()
        {
            InitializeComponent();
        }

        private void ExamineAssets_Click(object sender, RoutedEventArgs e) //Direct torwards Examine Exisiting Assets Page
        {
            new ExamineExistingAssets().Show();
            Close();
        }

        private void ExamineSheets_Click(object sender, RoutedEventArgs e) //Direct torwards Examine Exisitng Sheets Page 
        {
           
        }

        private void Home_Click(object sender, RoutedEventArgs e) //Return to Home Page
        {
            new MainWindow().Show();
            Close();
        }

        private void Back_Click(object sender, RoutedEventArgs e) //Return to whatever the previous page is
        {

        }
    }
}
