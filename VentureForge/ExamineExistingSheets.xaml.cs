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

        string modName;
        public ExamineExistingSheets(string modName)
        {
            this.modName = modName;
            Dictionary<string, Sheet> allsheets = Memory.modList[modName].SheetList;
            KeyValuePair<string, Sheet>[] keypairarray = allsheets.ToArray();
            InitializeComponent();
            for (int i = 0; i < allsheets.Count; i++)
            {
                System.Windows.Controls.Button newBtn = new Button();

                newBtn.Content = keypairarray[i].Key;
                newBtn.Name = keypairarray[i].Key;
                newBtn.Click += NewBtn_Click;
                
               

                sp.Children.Add(newBtn);

            }
            InitializeComponent();
        }

        private void NewBtn_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            new CreateSheets(Memory.modList[modName], button.Name).Show();
            Close();
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

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            new CreateModule().Show();
            Close();
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            Close();
        }
    }
}