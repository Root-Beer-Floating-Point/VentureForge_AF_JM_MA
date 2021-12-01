using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

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

        public void addContainer(string conName)
        {
            addedContainer = creator.getContainer(conName);
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
                labelText.Width = MainBorder.ActualWidth / 2;
                labelText.Text = "Give a label for your input field";
                stackPanel.Children.Add(textBox);
                textBox.Text = "";
                textBox.Width = MainBorder.ActualWidth / 2;
                textBox.TextChanged += TextBox_TextChanged;
            }
            labelText.TextInput += LabelText_TextInput; ;

            SheetContainer.Children.Add(border);
        }

        private void LabelText_TextInput(object sender, TextCompositionEventArgs e)
        {
            
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox text = sender as TextBox;
            string s = text.Name.TrimEnd('t', 'x', 't');
            creator.containerList[s].data = text.Text;
        }

        private void LabelText_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox text = sender as TextBox;
            string s = text.Name.TrimEnd('l', 'b', 'l');
            creator.containerList[s].label = text.Text;
        }
    }
}
