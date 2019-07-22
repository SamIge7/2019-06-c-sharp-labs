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

namespace Games_Week_Project_Noughts_And_Crosses
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        #region Private Members

        /// <summary>
        /// Holds the current results of cells in the active game
        /// </summary>
        private MarkType[] Results;

        /// <summary>
        /// True if it is Player 1's turn (X) or Player 2's Turn (O)
        /// </summary>
        private bool Player1Turn;

        /// <summary>
        /// True if the game has ended
        /// </summary>
        private bool GameEnded;
        #endregion

        #region Constructor
        /// <summary>
        /// Default Constructor
        /// </summary>
        public Window1()
        {
            InitializeComponent();
            NewGame();
        }

        #endregion

        private void NewGame()
        {
            //Create a new blank array of free cells
            Results = new MarkType[9];

            for (var i = 0; i < Results.Length; i++)
                Results[i] = MarkType.Free;

            //Make sure Player 1 starts the game
            Player1Turn = true;

            //Iterate every button on the grid
            GameGrid.Children.Cast<Button>().ToList().ForEach(button =>
            {
                button.Content = string.Empty; 
            });
        }


    }
}
