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
    public partial class Game : Window
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
        public Game()
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

            //Check for a winner
            CheckForAWinner();
        }

        /// <summary>
        /// Check if there is a winner of a 3 line straight
        /// </summary>
        private void CheckForAWinner()
        {
            //Check for Horizontal Wins

            #region Horizontal Wins
            //Row 0
            if (nResults[0] != MarkType.Free && (nResults[0] & nResults[1] & nResults[2]) == nResults[0])
            {
                //Game Ends
                GameHasEnded = true;

                //Highlight winning cells in green
                Button0_0.Background = Button1_0.Background = Button2_0.Background = Brushes.Green;
            }

            //Row 1
            if (nResults[3] != MarkType.Free && (nResults[3] & nResults[4] & nResults[5]) == nResults[3])
            {
                //Game Ends
                GameHasEnded = true;

                //Highlight winning cells in green
                Button0_1.Background = Button1_1.Background = Button2_0.Background = Brushes.Green;
            }

            //Row 2
            if (nResults[6] != MarkType.Free && (nResults[6] & nResults[7] & nResults[8]) == nResults[6])
            {
                //Game Ends
                GameHasEnded = true;

                //Highlight winning cells in green
                Button0_2.Background = Button1_2.Background = Button2_2.Background = Brushes.Green;
            }
            #endregion

            #region Vertical Wins

            //Column 1
            if (nResults[0] != MarkType.Free && (nResults[0] & nResults[3] & nResults[6]) == nResults[0])
            {
                //Game Ends
                GameHasEnded = true;

                //Highlight winning cells in green
                Button0_0.Background = Button0_1.Background = Button0_2.Background = Brushes.Green;
            }

            //Column 2
            if (nResults[1] != MarkType.Free && (nResults[1] & nResults[4] & nResults[7]) == nResults[1])
            {
                //Game Ends
                GameHasEnded = true;

                //Highlight winning cells in green
                Button1_0.Background = Button1_1.Background = Button1_2.Background = Brushes.Green;
            }

            //Column 3
            if (nResults[2] != MarkType.Free && (nResults[2] & nResults[5] & nResults[8]) == nResults[2])
            {
                //Game Ends
                GameHasEnded = true;

                //Highlight winning cells in green
                Button2_0.Background = Button2_1.Background = Button2_2.Background = Brushes.Green;
            }
            #endregion

            #region Diagonal Wins

            //Diagonal 1
            if (nResults[0] != MarkType.Free && (nResults[0] & nResults[4] & nResults[8]) == nResults[0])
            {
                //Game Ends
                GameHasEnded = true;

                //Highlight winning cells in green
                Button0_0.Background = Button1_1.Background = Button2_2.Background = Brushes.Green;
            }

            //Diagonal 2
            if (nResults[2] != MarkType.Free && (nResults[2] & nResults[4] & nResults[6]) == nResults[2])
            {
                //Game Ends
                GameHasEnded = true;

                //Highlight winning cells in green
                Button2_0.Background = Button1_1.Background = Button0_2.Background = Brushes.Green;
            }
            #endregion

            #region No Winners

            //Check for no winner and fill board
            if(!nResults.Any(item => item == MarkType.Free))
            {
                //Game Ended
                GameHasEnded = true;

                //Turn all cells orange
                Container.Children.Cast<Button>().ToList().ForEach(button =>
                {
                    button.Background = Brushes.Orange;
                });
            }
            #endregion
        }
    }
}
