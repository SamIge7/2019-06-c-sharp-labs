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
using System.Windows.Shapes;
namespace Games_Project
{
    /// <summary>
    /// Interaction logic for GameRules.xaml
    /// </summary>
    public partial class GameRules : Window
    {
        public GameRules()
        {
            InitializeComponent();
            Initialise();
        }

        void Initialise()
        {
            Rules.Text = "Welcome to the quiz!\nThe rules are nice and simple: Answer the questions as correctly as you can, if it is the right answer, you get the points, if not, you move on to the next question without any points!\nEnjoy!";
        }

        private void Begin_Click(object sender, RoutedEventArgs e)
        {
            Questions questions = new Questions();
            this.Visibility = Visibility.Hidden;
            questions.Show();
        }
    }
}
