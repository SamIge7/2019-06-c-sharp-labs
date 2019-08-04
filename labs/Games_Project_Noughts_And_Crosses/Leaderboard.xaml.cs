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

namespace Games_Project_Noughts_And_Crosses
{
    /// <summary>
    /// Interaction logic for Leaderboard.xaml
    /// </summary>
    public partial class Leaderboard : Window
    {
        List<MainLeaderboard2> mainLeaderboards;
        public Leaderboard()
        {
            InitializeComponent();
            Initialise();
        }

        void Initialise()
        {
            //Display Database in order of wins descending
            using (var db = new GameLeaderboard2Entities())
            {
                mainLeaderboards = db.MainLeaderboard2.ToList();
            }
            Leaderboard.ItemsSource = mainLeaderboards.OrderByDescending(i => i.Wins);
        }
    }
}
