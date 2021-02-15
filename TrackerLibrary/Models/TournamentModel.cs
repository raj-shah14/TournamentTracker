using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class TournamentModel
    {   
        /// <summary>
        /// Represents Name of the Tournament
        /// </summary>
        public string TournamentName { get; set; }

        /// <summary>
        /// Entry fees Required
        /// </summary>
        public decimal EntryFees { get; set; }

        /// <summary>
        /// List of teams Participating
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        /// <summary>
        /// List represents prizes that are going to be given
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        /// <summary>
        /// Represents the teams that will be competing in every Round
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
