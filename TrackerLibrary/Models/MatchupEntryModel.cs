using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchupEntryModel
    {   
        /// <summary>
        /// Represents One Team
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        
        /// <summary>
        /// Represents the Score
        /// </summary>
        public double Score { get; set; }
        
        /// <summary>
        /// Represents the Matchup that this team came from the winner 
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
    }
}
