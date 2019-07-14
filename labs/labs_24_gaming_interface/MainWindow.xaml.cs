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
using System.IO;

namespace labs_24_gaming_interface
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            if (File.Exists("Title.txt"))
            {
                TitleLabel.Content = "User Name: " + File.ReadAllText("Title.txt");
                InputName.Text = TitleLabel.Content.ToString();
                
            }
            else
            {
                File.Create("Title.txt");
            }

        }
        // When KeyUp event takes place, object will be item which caused the event
        // i.e. key we pressed e.g letter h. EventArgs is an array of Strings which contains any relevant
        // data for that event
        private void KeyUp_ChangeTitle(object sender, EventArgs e)
        {
            // add a line to save to file
            File.WriteAllText("Title.txt", InputName.Text);
        }

        private void Button01_Click(object sender, RoutedEventArgs e)
        {
           
            ListBox01.Items.Add($"Hey {InputName.Text}, Welcome! \n\n Click Start New Game to start! Have fun!") ; 
        }

        private void InputName_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox tb = sender as TextBox;
            TitleLabel.Content = tb.Text;
        }

        private void Button02_Click(object sender, RoutedEventArgs e)
        {
            SecondWindow objSecondWindow = new SecondWindow();
            this.Visibility = Visibility.Hidden;
            objSecondWindow.Show();
        }
    }
}
