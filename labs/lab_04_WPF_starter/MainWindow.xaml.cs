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

namespace lab_04_WPF_starter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static int counter = 0;
        public MainWindow()
        {
            InitializeComponent();
            Initialise();
        }

        void Initialise()
        {
            List<String> comboItems = new List<string> { "one", "two", "three" };
            ComboBox01.ItemsSource = comboItems;
        }
        private void Button01_Click(object sender, RoutedEventArgs e)
        {
            counter++;
            // ListBox01.Items.Add("Hey" + TextBox01.Text + ", You Clicked " + counter + " times");
            ListBox01.Items.Add($"Hey {TextBox01.Text}, You Clicked {counter} times");
        }
    }
}
