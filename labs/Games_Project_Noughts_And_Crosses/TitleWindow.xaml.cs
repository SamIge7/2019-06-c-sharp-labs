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
            
            Game game = new Game();
            this.Visibility = Visibility.Hidden;
            game.Show();
        }

      
    }
}
