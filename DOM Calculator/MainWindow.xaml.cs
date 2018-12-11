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

namespace DOM_Calculator
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

        double num1;
        double num2;
        string operation;
        double result;

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            if (displayText.Text == ("Enter a Value..."))
            {
                displayText.Text = b.Content.ToString();
            }
            else if(displayText.Text == ("0"))
            {
                displayText.Text = b.Content.ToString();
            }
            else if(displayText.Text == num1.ToString())
            {
                displayText.Text = b.Content.ToString();
            }
            else
            {
                displayText.Text += b.Content.ToString();
            }
        }



        private void Clear(object sender, RoutedEventArgs e)
        {
            displayText.Text = "0";
            double? num1 = null; 
        }

        private void Operator(object sender, RoutedEventArgs e)
        {
            num1 = Convert.ToDouble(displayText.Text);
            Button o = (Button)sender;
            operation = o.Content.ToString();
        }

        private void Equal(object sender, RoutedEventArgs e)
        {
            num2 = Convert.ToDouble(displayText.Text);

            if(operation == "+")
            {
                result = num1 + num2;
            }
            else if(operation == "-")
            {
                result = num1 - num2;
            }
            else if(operation == "*")
            {
                result = num1 * num2;
            }
            else if(operation == "/")
            {
                result = num1 / num2;
            }
            else
            {
                //Error
            }
            displayText.Text = result.ToString();
        }
    }

}
