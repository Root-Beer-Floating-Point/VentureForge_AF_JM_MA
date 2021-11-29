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
using System.Windows.Navigation;
using System.Windows.Shapes;
// comment to change stuff, test branch
namespace VentureForge
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
   
    public partial class MainWindow : Window
    {

        public Dictionary<string, Module> ModuleMasterList = new Dictionary<string, Module>();

        public static MainWindow _instance;
        public MainWindow()
        {
            _instance = this;
            InitializeComponent();

        }

        

        private void CreateModule_Click(object sender, RoutedEventArgs e)
        {

            new CreateModule().Show();
           Close();
            
        }


        private void FindModules_Click(object sender, RoutedEventArgs e)
        {
            new FindModules().Show();
            Close();
        }

        private void Modules_Click(Object sender, RoutedEventArgs e)
        {
            new Modules().Show();
            Close();
        }

        private void Login_Click(Object sender, RoutedEventArgs e)
        {
            // new Login().Show;
            // we aren't doing anything with this one yet
        }

        private void SignIn_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
