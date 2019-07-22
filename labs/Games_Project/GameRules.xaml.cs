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
            Rules.Text = "This is a competition between you two!\nAim of the game: Answer the question correctly and hope the other person doesn't!\nPlayer 1 types in their answer into the answer box first, then theyt click submit and then Player 2 answers and clicks submit.\nPoints vary depending on the difficulty of the question, and the quicker you answer it, the more points you get!\nHave fun!";
        }

        private void Begin_Click(object sender, RoutedEventArgs e)
        {
            Questions questions = new Questions();
            this.Visibility = Visibility.Hidden;
            questions.Show();
        }
    }
}
