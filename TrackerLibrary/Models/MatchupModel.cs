using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchupModel
    {

        /// <summary>
        /// Represents the Entries which are going to play
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();

        /// <summary>
        /// Winning the Team
        /// </summary>
        public TeamModel Winner { get; set; }

        /// <summary>
        /// Represents Matchup Rounds
        /// </summary>
        public string MatchupRound { get; set; }

    }
}
