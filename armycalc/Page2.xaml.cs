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

namespace armycalc
{
    /// <summary>
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        double a, b;
        char c;
        public Page2()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TB_result.Text += "2";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            TB_result.Text += "3";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            TB_result.Text += "4";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            TB_result.Text += "5";
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            TB_result.Text += "6";
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            TB_result.Text += "7";
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            TB_result.Text += "8";
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            TB_result.Text += "9";
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            TB_result.Text += "0";
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            TB_result.Text = "";
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            try
            {
                a = Convert.ToDouble(TB_result.Text);
                c = '+';
                TB_result.Text = "";
            }
            catch (Exception ex) { }

        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            try
            {
                a = Convert.ToDouble(TB_result.Text);
                c = '-';
                TB_result.Text = "";
            }
            catch (Exception ex) { }
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            try
            {
                a = Convert.ToDouble(TB_result.Text);
                c = '/';
                TB_result.Text = "";
            }
            catch (Exception ex) { }

        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            try
            {
                a = Convert.ToDouble(TB_result.Text);
                c = '*';
                TB_result.Text = "";
            }
            catch (Exception ex) { }
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            try
            {
                b = Convert.ToDouble(TB_result.Text);
                _ = c switch
                {
                    '+' => TB_result.Text = Convert.ToString(a + b),
                    '-' => TB_result.Text = Convert.ToString(a - b),
                    '/' => TB_result.Text = Convert.ToString(a / b),
                    '*' => TB_result.Text = Convert.ToString(a * b)
                };
            }
            catch (Exception ex) { }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page1());
        }
        private void MenuItem_Click1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page2());
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            if (TB_result.Text.Length == 0)
            {
                TB_result.Text = "";
                return;
            }

            a = Convert.ToDouble(TB_result.Text);
            TB_result.Text = Convert.ToString(Math.Tan(a));
        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            if (TB_result.Text.Length == 0)
            {
                TB_result.Text = "";
                return;
            }

            a = Convert.ToDouble(TB_result.Text);
            TB_result.Text = Convert.ToString(Math.Sin(a));
        }

        private void Button_Click_18(object sender, RoutedEventArgs e)
        {
            if (TB_result.Text.Length == 0)
            {
                TB_result.Text = "";
                return;
            }

            a = Convert.ToDouble(TB_result.Text);
            TB_result.Text = Convert.ToString(Math.Cos(a));
        }

        private void Button_Click_19(object sender, RoutedEventArgs e)
        {
            if (TB_result.Text.Length == 0)
            {
                TB_result.Text = "";
                return;
            }

            a = Convert.ToDouble(TB_result.Text);
            TB_result.Text = Convert.ToString(1 / Math.Tan(a));
        }

        private void Button_Click_20(object sender, RoutedEventArgs e)
        {
            if (TB_result.Text.Length == 0)
            {
                TB_result.Text = "";
                return;
            }

            a = Convert.ToDouble(TB_result.Text);
            TB_result.Text = Convert.ToString(1 / Math.Tan(a));
        }

        private void Button_Click_21(object sender, RoutedEventArgs e)
        {
            if (TB_result.Text.Length > 0)
            {
                TB_result.Text = TB_result.Text.Substring(0, TB_result.Text.Length - 1);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TB_result.Text += "1";
        }
    }
}
