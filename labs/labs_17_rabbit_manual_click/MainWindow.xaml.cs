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

namespace labs_17_rabbit_manual_click
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        static int counter = 0;
        static List<Rabbit> rabbits = new List<Rabbit>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button01_Click(object sender, RoutedEventArgs e)
        {
            counter++; // starts at zero, so first click means first rabbit is one
            var r = new Rabbit(counter);
            rabbits.Add(r);
            //display rabbits but first clear the display
            ListBox01.Items.Clear();
            ListBox01.Items.Add("Loop" + counter);

            foreach (var rabbit in rabbits)
            {
                rabbit.Age++;
                ListBox01.Items.Add($"{rabbit.Name} is {rabbit.Age}");
            }
        }
    }
   
}
