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
    /// Interaction logic for ContainerPrompt.xaml
    /// </summary>
    public partial class ContainerPrompt : Window
    {

        public String nameInput = "";
        public bool cTypeInput = false;
        public bool dTypeInput = false;
        public bool name = false;
        public bool type = false;
        public bool type2 = false;
        Window previousWindow;
        Sheet sheet;
        public ContainerPrompt()
        {
            InitializeComponent();
        }
        public ContainerPrompt(Window window, Sheet s)
        {
            sheet = s;
            previousWindow = window;
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (NameText.Text != null && NameText.Text != "")
            {
                name = true;
                nameInput = NameText.Text;
                checkButtonState();
            }
            else
            {
                name = false;
                checkButtonState();
            }
        }

        private void Label_Checked(object sender, RoutedEventArgs e)
        {
            type = true;
            cTypeInput = false;
            checkButtonState();
            DataTypeLabel.Visibility = Visibility.Hidden;
            Integer.Visibility = Visibility.Hidden;
            String.Visibility = Visibility.Hidden;
        }

        private void Input_Checked(object sender, RoutedEventArgs e)
        {
            type = true;
            cTypeInput = true;
            checkButtonState();
            DataTypeLabel.Visibility = Visibility.Visible;
            Integer.Visibility = Visibility.Visible;
            String.Visibility = Visibility.Visible;
        }

        private void String_Checked(object sender, RoutedEventArgs e)
        {
            type2 = true;
            dTypeInput = false;
            checkButtonState();
        }

        private void Integer_Checked(object sender, RoutedEventArgs e)
        {
            type2 = true;
            dTypeInput = true;
            checkButtonState();
        }

        public void checkButtonState()
        {
            if (name == true && type == true && ((cTypeInput == true && type2 == true) || cTypeInput == false))
            {
                Done.IsEnabled = true;
            }
            else
            {
                Done.IsEnabled = false;
            }
        }

        private void Done_Click(object sender, RoutedEventArgs e)
        {
            sheet.addContainer(nameInput, cTypeInput, dTypeInput);
            
            Console.WriteLine("bye");
            Close();
            Console.WriteLine("hi");
        }


    }
}
