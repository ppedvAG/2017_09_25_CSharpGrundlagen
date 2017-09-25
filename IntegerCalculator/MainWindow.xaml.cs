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

namespace IntegerCalculator
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

        private void PlusButtonClick(object sender, RoutedEventArgs e)
        {
            var zahl1 = int.Parse(Zahl1TextBox.Text);
            var zahl2 = int.Parse(Zahl2TextBox.Text);

            var ergebnis = zahl1 + zahl2;

            ErgebnisTextBox.Text = ergebnis.ToString();
        }

        private void MinusButtonClick(object sender, RoutedEventArgs e)
        {
            ErgebnisTextBox.Text = (int.Parse(Zahl1TextBox.Text) - int.Parse(Zahl2TextBox.Text)).ToString();
        }

        private void MalButtonClick(object sender, RoutedEventArgs e)
        {
            ErgebnisTextBox.Text = (int.Parse(Zahl1TextBox.Text) * int.Parse(Zahl2TextBox.Text)).ToString();
        }

        private void DividiertButtonClick(object sender, RoutedEventArgs e)
        {
            ErgebnisTextBox.Text = (int.Parse(Zahl1TextBox.Text) / int.Parse(Zahl2TextBox.Text)).ToString();
        }

        private void ModuloButtonClick(object sender, RoutedEventArgs e)
        {
            ErgebnisTextBox.Text = (int.Parse(Zahl1TextBox.Text) % int.Parse(Zahl2TextBox.Text)).ToString();
        }
    }
}
