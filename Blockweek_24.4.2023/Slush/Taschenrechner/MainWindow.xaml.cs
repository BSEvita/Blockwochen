using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Net.Mime;
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
using static Taschenrechner.assets.cs.Calculator;
/*
 *
 *
 *
 *      ⣠⣤⣤⣤⣤⣤⣄⡀
⠀⠀⠀⠀⠀⢰⡿⠋⠁⠀⠀⠈⠉⠙⠻⣷⣄
⠀⠀⠀⠀⢀⣿⠇⠀⢀⣴⣶⡾⠿⠿⠿⢿⣿⣦⡀
⠀⠀⣀⣀⣸⡿⠀⠀⢸⣿⣇⠀⠀⠀⠀⠀⠀⠙⣷⡀
⠀⣾⡟⠛⣿⡇⠀⠀⢸⣿⣿⣷⣤⣤⣤⣤⣶⣶⣿⠇
⢀⣿⠀⢀⣿⡇⠀⠀⠀⠻⢿⣿⣿⣿⣿⣿⠿⣿⡏⠀⠀⠀⠀⢴⣶⣶⣿⣿⣿⣆
⢸⣿⠀⢸⣿⡇⠀⠀⠀⠀⠀⠈⠉⠁⠀⠀⠀⣿⡇⣀⣠⣴⣾⣮⣝⠿⠿⠿⣻⡟
⢸⣿⠀⠘⣿⡇⠀⠀⠀⠀⠀⠀⠀⣠⣶⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠁⠉⠀
⠸⣿⠀⠀⣿⡇⠀⠀⠀⠀⠀⣠⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠟⠉
⠀⠻⣷⣶⣿⣇⠀⠀⠀⢠⣼⣿⣿⣿⣿⣿⣿⣿⣛⣛⣻⠉⠁
⠀⠀⠀⠀⢸⣿⠀⠀⠀⢸⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡇
⠀⠀⠀⠀⢸⣿⣀⣀⣀⣼⡿⢿⣿⣿⣿⣿⣿⡿⣿⣿⡿
⠀⠀⠀⠀⠀⠙⠛⠛⠛⠋⠁⠀⠙⠻⠿⠟⠋⠑⠛⠋⠀
 * 
 */
namespace Taschenrechner
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int first;
        private int second;
        private double result = 0;
        private string op;
        
        public MainWindow()
        {
            InitializeComponent();
        }
        /*
         *
         *
         *              CONTROL GATEWAY
         * 
         */
        private void Button_Delete(object sender, RoutedEventArgs e)
        {
            textBox.Clear();
            first = 0;
            second = 0;
            result = 0;
        }
        /*
         *
         *              CALCULATION GATEWAY
         *
         * 
         */
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            textBox.Text += btn.Content.ToString();
            second = Int32.Parse(textBox.Text);
        }

        private void Button_Divide(object sender, RoutedEventArgs e)
        {
            first = Int32.Parse(textBox.Text);
            op = "div";
            textBox.Clear();
            
        }

        private void Button_Sub(object sender, RoutedEventArgs e)
        {
            first = Int32.Parse(textBox.Text);
            op = "sub";
            textBox.Clear();
        }

        private void Button_Minus(object sender, RoutedEventArgs e)
        {
            first = Int32.Parse(textBox.Text);
            op = "min";
            textBox.Clear();
        }

        private void Button_Plus(object sender, RoutedEventArgs e)
        {
            first = Int32.Parse(textBox.Text);
            op = "plu";
            textBox.Clear();
        }

        private void Button_Pow(object sender, RoutedEventArgs e)
        {
            first = Int32.Parse(textBox.Text);
            op = "pow";
            textBox.Clear();
        }

        private void Button_Sqrt(object sender, RoutedEventArgs e)
        {
            first = Int32.Parse(textBox.Text);
            op = "sqr";
            textBox.Clear();
        }

        private void Button_Log(object sender, RoutedEventArgs e)
        {
            first = Int32.Parse(textBox.Text);
            op = "log";
            textBox.Clear();
        }

        private void Button_Fac(object sender, RoutedEventArgs e)
        {
            first = Int32.Parse(textBox.Text);
            op = "fac";
            textBox.Clear();
        }

        private void Button_Sin(object sender, RoutedEventArgs e)
        {
            first = Int32.Parse(textBox.Text);
            op = "sin";
            textBox.Clear();
        }

        private void Button_Cos(object sender, RoutedEventArgs e)
        {
            first = Int32.Parse(textBox.Text);
            op = "cos";
            textBox.Clear();
        }
        /*
         *
         *  @Button_Con
         *
         * 
         */
        public void Button_Con(object sender, RoutedEventArgs e)
        {
            first = Int32.Parse(textBox.Text);
            op = "con";
            textBox.Clear();
        }

        public void Button_Tan(object sender, RoutedEventArgs e)
        {
            first = Int32.Parse(textBox.Text);
            op = "tan";
            textBox.Clear();
        }

        private void Button_Equals(object sender, RoutedEventArgs e)
        {
            first = Int32.Parse(textBox.Text);
            result = 0;
            switch (op)
            {
                case "div":
                    result = Divide(first, second);
                    break;
                case "sub":
                    result = Multiply(first, second);
                    break;
                case "min":
                    result = Subtract(first, second);
                    break;
                case "plu":
                    result = Add(first, second);
                    break;
                case "pow":
                    result = Power(first, second);
                    break;
                case "sqrt":
                    result = SquareRoot(first);
                    break;
                case "log":
                    result = Logarithm(first, second);
                    break;
                case "fac":
                    result = Factorial(first);
                    break;
                case "sin":
                    result = Sine(first);
                    break;
                case "cos":
                    result = Cosine(first);
                    break;
                case "tan":
                    result = Cosine(first);
                    break;
                default:
                    result = 0000;
                    break;
            }

            if (textBox.Text == "0")
            {
                textBox.Clear();
            }
            textBox.Text = result.ToString();
        }
    }
}
