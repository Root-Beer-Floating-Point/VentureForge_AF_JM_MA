using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Win32;
using System.IO;
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
    /// Interaction logic for ViewDocument.xaml
    /// </summary>
    public partial class ViewDocument : Window
    {
        public ViewDocument()
        {
            InitializeComponent();
        }

        private void HomePage_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            Close();
        }

        private void PreviousPage_Click(object sender, RoutedEventArgs e)
        {
            new ExamineExistingAssets().Show();
            Close();
        }

        private void LoginPage_Click(object sender, RoutedEventArgs e)
        {
            new ErrorPage().Show();
            Close();
        }

        private void SignInPage_Click(object sender, RoutedEventArgs e)
        {
            new ErrorPage().Show();
            Close();
        }

        private void OpenFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {

                myTextBox.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }
    }
}