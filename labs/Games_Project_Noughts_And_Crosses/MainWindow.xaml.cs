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

namespace Games_Project_Noughts_And_Crosses
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Private Members
        /// <summary>
        /// Holds the current results of cells in the active game
        /// </summary>
        private MarkType[] nResults;

        /// <summary>
        /// True if it is Player 1's Turn (X) or Player 2's Turn (O)
        /// </summary>
        private bool Player1Turn;

        /// <summary>
        /// True if the game has ended
        /// </summary>
        private bool GameHasEnded;
        #endregion

        #region Constructor
        /// <summary>
        /// Default Constructor
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            NewGame();
        }
        #endregion

        private void NewGame()
        {
            //Create a new blank array of free cells
            nResults = new MarkType[9];

            for (var i = 0; i < nResults.Length; i++)
                nResults[i] = MarkType.Free;

            //Make sure that Player 1 starts the game
            Player1Turn = true;

            //Iterate every button on Grid.
            Container.Children.Cast<Button>().ToList().ForEach(button =>
            {

            });
        }
    }
}
