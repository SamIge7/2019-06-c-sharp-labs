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

        /// <summary>
        /// Starts a new game and clears all values back to the start
        /// </summary>
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
                //Change Background, Foreground and Content to default Values
                button.Content = string.Empty;
                button.Background = Brushes.White;
                button.Foreground = Brushes.Blue;
            });

            //Make sure game hasn't finished
            GameHasEnded = false;
        }

        /// <summary>
        /// Handles a Button Click Event
        /// </summary>
        /// <param name="sender">The button that was clicked</param>
        /// <param name="e">The event of the click</param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Start a new game on the click after it has finished
            if (GameHasEnded)
            {
                NewGame();
                return;
            }

            //Cast the sender to a button
            var button = (Button)sender;

            //Find the button position in the array
            var column = Grid.GetColumn(button);
            var row = Grid.GetRow(button);

            var index = column + (row * 3);

            //Don;t do anything if the cell already has a value in it
            if (nResults[index] != MarkType.Free)
                return;

            //Set the cell value based on which player's turn it is
            nResults[index] = Player1Turn ? MarkType.Cross : MarkType.Nought;

            //Set button text to the result
            button.Content = Player1Turn ? "X" : "O";

            //Change Noughts to Green
            if (!Player1Turn)
                button.Foreground = Brushes.Red;

            //Toggle the players turns.
            if (Player1Turn)
                Player1Turn = false;
            else
                Player1Turn = true;
        }
    }
}
