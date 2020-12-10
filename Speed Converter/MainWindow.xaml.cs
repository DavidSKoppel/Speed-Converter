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

namespace Speed_Converter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        bool ButtonState = true; 

        private void TextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            double input = double.Parse(TextBox1.Text);
            if (ButtonState == true)
            {
                double result = input * 0.44704;
                Label1.Content = input.ToString() + " MPH => " + string.Format("{0:0.00}", result) + " M/s";
            }
            else if (ButtonState == false)
            {
                double result = input / (1609.44 / 3600);
                Label1.Content = input.ToString() + " M/s => " + string.Format("{0:0.00}", result) + " MPH";
            }
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            if (ButtonState == true)
                ButtonState = false;
            else if (ButtonState == false)
                ButtonState = true;
        }
    }
}
