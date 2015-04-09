using System;
using System.Windows;
using Calculator_solve;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //local var declaration
        int answer;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_0_Click(object sender, RoutedEventArgs e)
        {
            textBox.AppendText("0");
        }

        private void button_1_Click(object sender, RoutedEventArgs e)
        {
            textBox.AppendText("1");
        }

        private void button_2_Click(object sender, RoutedEventArgs e)
        {
            textBox.AppendText("2");
        }

        private void button_3_Click(object sender, RoutedEventArgs e)
        {
            textBox.AppendText("3");
        }

        private void button_4_Click(object sender, RoutedEventArgs e)
        {
            textBox.AppendText("4");
        }

        private void button_5_Click(object sender, RoutedEventArgs e)
        {
            textBox.AppendText("5");
        }

        private void button_6_Click(object sender, RoutedEventArgs e)
        {
            textBox.AppendText("6");
        }

        private void button_7_Click(object sender, RoutedEventArgs e)
        {
            textBox.AppendText("7");
        }

        private void button_8_Click(object sender, RoutedEventArgs e)
        {
            textBox.AppendText("8");
        }

        private void button_9_Click(object sender, RoutedEventArgs e)
        {
            textBox.AppendText("9");
        }

        private void button_add_Click(object sender, RoutedEventArgs e)
        {
            int index = textBox.GetLastVisibleLineIndex();
            string line = textBox.GetLineText(index);
            if (line.Equals(""))
            {
                string sol = Convert.ToString(answer);
                textBox.AppendText( sol + " + ");
            }
            else
            {
                textBox.AppendText(" + ");
            }
        }

        private void button_sub_Click(object sender, RoutedEventArgs e)
        {
            int index = textBox.GetLastVisibleLineIndex();
            string line = textBox.GetLineText(index);
            if (line.Equals(""))
            {
                string sol = Convert.ToString(answer);
                textBox.AppendText(sol + " - ");
            }
            else
            {
                textBox.AppendText(" - ");
            }
        }

        private void button_mul_Click(object sender, RoutedEventArgs e)
        {
            int index = textBox.GetLastVisibleLineIndex();
            string line = textBox.GetLineText(index);
            if (line.Equals(""))
            {
                string sol = Convert.ToString(answer);
                textBox.AppendText(sol + " * ");
            }
            else
            {
                textBox.AppendText(" * ");
            }
        }

        private void button_div_Click(object sender, RoutedEventArgs e)
        {
            int index = textBox.GetLastVisibleLineIndex();
            string line = textBox.GetLineText(index);
            if (line.Equals(""))
            {
                string sol = Convert.ToString(answer);
                textBox.AppendText(sol + " / ");
            }
            else
            {
                textBox.AppendText(" / ");
            }
        }

        private void button_eq_Click(object sender, RoutedEventArgs e)
        {
            int index;
            index = textBox.GetLastVisibleLineIndex();
            string equation = textBox.GetLineText(index);
            answer = Solve(equation);
            string sol = Convert.ToString(answer);
            textBox.AppendText(" = " + sol + "\n");
            if (index>=3)
            {
                textBox.ScrollToEnd();
            }
        }

        private void button_clear_Click(object sender, RoutedEventArgs e)
        {
            textBox.Clear();
        }
    }
}
