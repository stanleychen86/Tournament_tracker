using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// represents one team in the matchup
        /// </summary>
         
        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        /// reperents the score for this particular team
        /// </summary>

        public double Score { get; set; }


        /// <summary>
        /// represents the matchup this team came from as the winner
        /// </summary>

        public MatchupModel ParentMatchup { get; set; }

     
    }
}
