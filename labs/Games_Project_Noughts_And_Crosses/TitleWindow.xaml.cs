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
        List<MainLeaderboard> mainLeaderboards;
        public TitleWindow()
        {
            InitializeComponent();
            Initialise();
        }

        void Initialise()
        {
            using (var db = new GameLeaderboardEntities())
            {
                mainLeaderboards = db.MainLeaderboard.ToList();
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

                using (var db = new GameLeaderboardEntities())
                {
                    MainLeaderboard newplayer1 = new MainLeaderboard();
                    newplayer1.playername = Player1Name.Text;
                    newplayer1.Wins = p1wins;
                    newplayer1.Losses = p1losses;
                    db.MainLeaderboard.Add(newplayer1);

                    MainLeaderboard newplayer2 = new MainLeaderboard();
                    newplayer2.playername = Player2Name.Text;
                    newplayer2.Wins = p2wins;
                    newplayer2.Losses = p2losses;
                    db.MainLeaderboard.Add(newplayer2);
                    db.SaveChanges();
                }
            }

            Game game = new Game();
            this.Visibility = Visibility.Hidden;
            game.Show();
        }

      
    }
}
