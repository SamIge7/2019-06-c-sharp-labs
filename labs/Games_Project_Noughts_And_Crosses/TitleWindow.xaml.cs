using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.MobileControls;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Games_Project_Noughts_And_Crosses
{
    /// <summary>
    /// Interaction logic for TitleWindow.xaml
    /// </summary>
    public partial class TitleWindow : Window
    {
        List<MainLeaderboard2> mainLeaderboards;
        public TitleWindow()
        {
            InitializeComponent();
            Initialise();
        }

        void Initialise()
        {
            using (var db = new GameLeaderboard2Entities())
            {
                mainLeaderboards = db.MainLeaderboard2.ToList();
            }
            Leaderboard.ItemsSource = mainLeaderboards;
        }

        private void BeginGame_Click(object sender, RoutedEventArgs e)
        {
            if(Player1Name.Text == "" || Player2Name.Text == "")
            {
                MessageBox.Show("Make sure both players have put their names in");
            }
            else
            {
                string player1name = Player1Name.Text;
                string player2name = Player2Name.Text;

                int p1wins = 0;
                int p1losses = 0;
                int p2wins = 0;
                int p2losses = 0;

                using (var db = new GameLeaderboard2Entities())
                {
                    MainLeaderboard2 newplayer1 = new MainLeaderboard2();
                    newplayer1.PlayerName = Player1Name.Text;
                    newplayer1.Wins = p1wins;
                    newplayer1.Losses = p1losses;
                    db.MainLeaderboard2.Add(newplayer1);

                    MainLeaderboard2 newplayer2 = new MainLeaderboard2();
                    newplayer2.PlayerName = Player2Name.Text;
                    newplayer2.Wins = p2wins;
                    newplayer2.Losses = p2losses;
                    db.MainLeaderboard2.Add(newplayer2);
                    db.SaveChanges();
                }
            }

            Game game = new Game();
            this.Visibility = Visibility.Hidden;
            game.Show();
        }

      
    }
}
