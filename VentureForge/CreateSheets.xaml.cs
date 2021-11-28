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
    /// Interaction logic for CreateSheets.xaml
    /// </summary>
    /// 
    
    public class Sheet
    {

        public String name = "";


        public Sheet()
        {

        }// empty arg constructor

        public Sheet(String n)
        {
            this.name = n;
        }


    }


    public partial class CreateSheets : Window
    {
        public Module mod;
        public Sheet creator = new Sheet();
        public String nameString = "";
        public CreateSheets(Module mod)
        {
            InitializeComponent();
            this.mod = mod;
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            Close();
        }

        private void SginIn_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Login_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddContainer_Click(object sender, RoutedEventArgs e)// allows txt, containers, and data boxes within
        {

        }

        private void CreatorName_TextChanged(object sender, TextChangedEventArgs e)
        {
            nameString = CreatorName.Text;
            
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            creator.name = nameString;
            mod.AddSheet(creator.name, creator);
        }
    }
}
