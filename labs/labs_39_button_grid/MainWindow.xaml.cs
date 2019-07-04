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

namespace labs_39_button_grid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Button> buttons = new List<Button>();
        public MainWindow()
        {
            InitializeComponent();
            Initialise();
        }

        void Initialise()
        {
            for (int i = 0; i < 100; i++)
            {
                var b = new Button();
                b.Name = "Button" + i;
                b.Content = "Button" + (i+1);
                b.Click += new RoutedEventHandler(button_click);
                buttons.Add(b);
                MainGrid.Children.Add(b);
                Grid.SetColumn(b, i % 10);
                Grid.SetRow(b, i / 10);
                //generate a random number between 0 and 5
                int rand = RandomNumberGenerator(0,5);
                System.Threading.Thread.Sleep(30);
                //match number with enum number (use casting)
                switch(rand)

                {
                    case 0:
                        b.Background = Brushes.Blue;
                        break;
                    case 1:
                        b.Background = Brushes.Red;
                        break;
                    case 2:
                        b.Background = Brushes.Green;
                        break;
                    case 3:
                        b.Background = Brushes.Yellow;
                        break;
                    case 4:
                        b.Background = Brushes.Purple;
                        break;
                    case 5:
                        b.Background = Brushes.Pink;
                        break;
                }
                //set colour of button to be chosen colour
            }
        }

        private void button_click (object sender, EventArgs e)
        {
            var b = (Button)sender;
            MessageBox.Show($"{b.Name} is at row {Grid.GetRow(b)} and column {Grid.GetColumn(b)}, and the colour is {b.Background}");
            //can we tell the colour??
            
        }

        private int RandomNumberGenerator(int start, int end)
        {
            Random randomizer = new Random();
            int randNum = randomizer.Next(start, end);
            return randNum;
        }
    }

    enum colours
    {
        blue, red, green, yellow, purple, pink
    }
}
