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
    /// Interaction logic for UploadAssests.xaml
    /// </summary>
    public partial class UploadAssests : Window
    {
        public UploadAssests()
        {
            InitializeComponent();
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            Close();
                
        }

        /**
         * Added function to upload a file from user and display the path of the file
         */
        private void UploadFile_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //if (openFileDialog.ShowDialog() == true) ;

            bool? response = openFileDialog.ShowDialog();

             
            if(response == true)
            {
          
               // string filePath = openFileDialog.FileName;
                myTextBox.Text = openFileDialog.FileName;
                // MessageBox.Show(filePath);
               
            }
            

        }

        private void CreateTable_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SignIn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
