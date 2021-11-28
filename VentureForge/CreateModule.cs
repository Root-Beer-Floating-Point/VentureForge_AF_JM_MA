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
    /// 

    public class Module
    {

        public String name = "";
        public Dictionary<String, Sheet> SheetList = new Dictionary<string, Sheet>();
        int count = 0;

        public Module()
        {

        }// end empty argument constructor

        public Module(string name)
        {
            this.name = name;
        }// end Module Constructor

        public void AddSheet(String sheetName, Sheet sheet)
        {
            if (count == 0) { SheetList.Add(sheetName, sheet); }
            else { SheetList.Remove(sheetName); SheetList.Add(sheetName, sheet); }
            count++;
        }

    }// end class Module

    public partial class CreateModule : Window
    {

        public Module mod = new Module();
        public bool named = false;
        public CreateModule()
        {
            InitializeComponent();
            
        }
        private void UploadAssests_Click(object sender, RoutedEventArgs e)
        {
            if (named) {
                new UploadAssests().Show();
                Close();
            }
            
        }

        private void ExamineAssets_Click(object sender, RoutedEventArgs e)
        {
            if (named) {
                new ExamineExistingAssests().Show();
                Close();
            }
            
        }

        private void CreateSheets_Click(object sender, RoutedEventArgs e)
        {
            if (named) {
                new CreateSheets(mod).Show();
                Close();
            }
            
        }

        private void ExamineSheets_Click(object sender, RoutedEventArgs e)
        {
            if (named) {
                new ExamineExistingSheets().Show();
                Close();
            }
            
        }

        private void UploadModule_Click(object sender, RoutedEventArgs e)
        {
            if (named)
            {
                new UploadeModule().Show();
                Close();
            }
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            if (named) {
                new MainWindow().Show();
                Close();
            }
            
        }

        private void SginIn_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Login_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ModName_TextChanged(object sender, TextChangedEventArgs e)
        {
            mod.name = nameBox.Text;
            named = true;
        }
    }
}
