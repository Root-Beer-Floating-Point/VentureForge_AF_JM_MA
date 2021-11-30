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
        public bool name = false;
        public bool type = false;
        public bool type2 = false;
        public ContainerPrompt()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (NameText.Text != null && NameText.Text != "")
            {
                name = true;
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
            checkButtonState();
        }

        private void Input_Checked(object sender, RoutedEventArgs e)
        {
            type = true;
            checkButtonState();
        }

        private void String_Checked(object sender, RoutedEventArgs e)
        {
            type2 = true;
            checkButtonState();
        }

        private void Integer_Checked(object sender, RoutedEventArgs e)
        {
            type2 = true;
            checkButtonState();
        }

        public void checkButtonState()
        {
            if (name == true && type == true && type2 == true)
            {
                Done.IsEnabled = true;
            }
            else
            {
                Done.IsEnabled = false;
            }
        }
    }
}
