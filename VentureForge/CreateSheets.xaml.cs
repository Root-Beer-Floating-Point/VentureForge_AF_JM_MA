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
    
    


    public partial class CreateSheets : Window
    {
        public Module mod;
        public Dictionary<string, Module> masterList = Memory.modList;
        public Sheet creator;
        public String nameString = "";
        public Window window;
        public CreateSheets window2;
        public Container addedContainer;
        public Border border;
        public TextBox textBox;
        public StackPanel stackPanel;
        public TextBox labelText;
        public CreateSheets(Module mod)
        {
            InitializeComponent();
            this.mod = mod;
            window = this;
            window2 = this;
            
            creator = new Sheet();
            
        }

        public CreateSheets(Module mod, string sheetname)
        {
            this.mod = mod;
            nameString = sheetname;



            InitializeComponent();
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            Close();
        }

        private void SginIn_Click(object sender, RoutedEventArgs e)
        {
            new ErrorPage().Show();
            Close();
        }
        private void Login_Click(object sender, RoutedEventArgs e)
        {
            new ErrorPage().Show();
            Close();
        }

        private void AddContainer_Click(object sender, RoutedEventArgs e)// allows txt, containers, and data boxes within
        {
            new ContainerPrompt(window2, creator).Show();
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

        private void Back_Click(object sender, RoutedEventArgs e)
        {
           
            new CreateModule(mod.name).Show();
            Close();

        }

        public void addContainer()
        {
            addedContainer = creator.getContainer();
            stackPanel = new StackPanel();
            stackPanel.Name = addedContainer.name;
            textBox = new TextBox();
            textBox.Name = addedContainer.name + "txt";
            border = new Border();
            border.Name = addedContainer.name + "bdr";
            labelText = new TextBox();
            labelText.Name = addedContainer.name + "lbl";
            border.Width = MainBorder.ActualWidth;
            SheetContainer.Width = MainBorder.ActualWidth;

            border.Child = stackPanel;
            stackPanel.Orientation = Orientation.Horizontal;
            stackPanel.Children.Add(labelText);
            labelText.Text = "Enter whatever your heart desires";
            labelText.Width = MainBorder.ActualWidth;
            labelText.TextWrapping = TextWrapping.Wrap;
            textBox.TextWrapping = TextWrapping.Wrap;
            

            if (addedContainer.dataEntry == true)
            {
                labelText.Width = MainBorder.ActualWidth/2;
                labelText.Text = "Give a label for your input field";
                stackPanel.Children.Add(textBox);
                textBox.Text = "";
                textBox.Width = MainBorder.ActualWidth/2;
            }
            

            SheetContainer.Children.Add(border);
        }
    }
}
