using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games_Week_Project_Noughts_And_Crosses
{/// <summary>
/// The type of valiue a cell in the game is currently at
/// </summary>
    public enum MarkType
    {
        /// <summary>
        /// The cell hasn't been clicked yet
        /// </summary>
        Free,
        /// <summary>
        /// The cell is an O
        /// </summary>
        Nought,
        /// <summary>
        /// The cell is an X
        /// </summary>
        Cross
    }
}
