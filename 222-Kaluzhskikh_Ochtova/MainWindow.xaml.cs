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

namespace _222_Kaluzhskikh_Ochtova
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(X.Text) || string.IsNullOrWhiteSpace(P.Text))
            {
                MessageBox.Show("All fields must be filled in.");
                return;
            }

            if (!double.TryParse(X.Text, out double x) || !double.TryParse(P.Text, out double p))
            {
                MessageBox.Show("Enter the correct numbers.");
                return;
            }

            double result = 0;
            double xx = 0;
            double absP = Math.Abs(p);

            if (sh.IsChecked == true)
            {
                xx = Math.Sinh(p);
            }
            else if (x2.IsChecked == true)
            {
                xx = Math.Pow(p, 2);
            }
            else if (ex.IsChecked == true)
            {
                xx = Math.Exp(p);
            }

            if (x > absP)
            {
                result = 2 * Math.Pow(xx, 3) + 3 * Math.Pow(p, 2);
            }
            else if (x > 3 && x < absP)
            {
                result = Math.Abs(xx - p);
            }
            else if (x == absP)
            {
                result = Math.Pow(xx - p, 2);
            }
            else
            {
                MessageBox.Show("The value of X does not fall within the valid range.");
            }

            Result.Text = result.ToString();

        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            X.Clear();
            P.Clear();
            Result.Clear();

        }
    }
}
