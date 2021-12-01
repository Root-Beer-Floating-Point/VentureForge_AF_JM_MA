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
    /// Interaction logic for UseExistingSheet.xaml
    /// </summary>
    public partial class UseExistingSheet : Window
    {

        
        public Module mod = new Module();
        string sheetname = "";
        Sheet creator = new Sheet();
        
        public UseExistingSheet(Module mod, String sheetname)
        {
            this.mod = mod;
            this.sheetname = sheetname;
            creator = mod.SheetList[sheetname];
            
            
            InitializeComponent();
            SetUpSheet();
            CreatorName.Text = sheetname;
        }

        public void SetUpSheet()
        {

          
            int i = 0;
            foreach (KeyValuePair<string, Container> ele1 in mod.SheetList[sheetname].containerList)
            { Console.WriteLine(ele1.Key);
                 Window window;
         CreateSheets window2;
         Container addedContainer;
         Border border;
         Label textBox;
         StackPanel stackPanel;
         Label labelText;

        creator = mod.SheetList[sheetname];

                
                addedContainer = ele1.Value;
                stackPanel = new StackPanel();
                stackPanel.Name = addedContainer.name;
                textBox = new Label();
                textBox.Name = addedContainer.name + "txt";
                border = new Border();
                border.Name = addedContainer.name + "bdr";
                labelText = new Label();
                labelText.Name = addedContainer.name + "lbl";
                border.Width = MainBorder.ActualWidth;
                SheetContainer.Width = MainBorder.ActualWidth;

                border.Child = stackPanel;
                stackPanel.Orientation = Orientation.Horizontal;
                stackPanel.Children.Add(labelText);
                //labelText.Text = "Enter whatever your heart desires";
                labelText.Width = MainBorder.ActualWidth;
                //labelText.TextWrapping = TextWrapping.Wrap;
                //textBox.TextWrapping = TextWrapping.Wrap;


                if (addedContainer.dataEntry == true)
                {
                    labelText.Width = MainBorder.ActualWidth / 2;
                    
                    stackPanel.Children.Add(textBox);
                    textBox.Content= ele1.Value.data;
                    textBox.Width = MainBorder.ActualWidth / 2;
                }
                labelText.Content= ele1.Value.label;
                
            }
           
        }

        private void Home_Click(object sender, RoutedEventArgs e) //Return to Home Page
        {
            new MainWindow().Show();
            Close();
        }

        private void Back_Click(object sender, RoutedEventArgs e) //Return to whatever the previous page is
        {
            new ExamineExistingSheets(mod.name).Show();
            Close();
        }
    }
}
