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

    

    public partial class CreateModule : Window
    {
        
        public Module mod = new Module();
        public Dictionary<string, Module> masterList = MainWindow._instance.ModuleMasterList;
        public String modname = "";
        public bool named = false;
        public int savecount = 0;
        public CreateModule()
        {
            
            InitializeComponent();
            
            
            
        }

        public CreateModule(String name)
        {
            
            mod = masterList[name];

            String sheets = "- ";

            foreach(KeyValuePair<string, Sheet> ele1 in mod.SheetList)
            {
                sheets = ele1.Key + " - ";
            }

            
            InitializeComponent ();
            ShowName.Text = mod.name;// need to repeat with all data shown
            CreatedSheets.Text = sheets;
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
            
                masterList = null;
                new MainWindow().Show();
                Close();
            
            
        }

        private void SginIn_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Login_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ModName_TextChanged(object sender, TextChangedEventArgs e)
        {
          
            modname = nameBox.Text;
            named = true;
            
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (named) 
            { 
            
                ShowName.Text = modname;
                mod.name = modname;
                if(savecount == 0) { masterList.Add(mod.name, mod); }
                else { masterList.Remove(mod.name); masterList.Add(mod.name, mod); }
                savecount++;
            
            }
            
        }
    }
}
