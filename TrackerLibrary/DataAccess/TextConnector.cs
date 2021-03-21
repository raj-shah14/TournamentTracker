using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {

        private const string PrizesFile = "PrizeModel.csv";
        private const string PersonFile = "PeopleFile.csv";
        private const string TeamFile = "TeamFile.csv";
        // TODO - Wire Create Prize for Text files
        /// <summary>
        /// Create prize for Text File
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            int currentId = 1;
            if (prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }
                
            model.Id = currentId;
            prizes.Add(model);
            prizes.SaveToPrizeFile(PrizesFile);
            return model;
        }

        public PersonModel CreatePerson(PersonModel person)
        {
            List<PersonModel> people = PersonFile.FullFilePath().LoadFile().ConvertToPersonModels();
            int currentId = 1;
            if(people.Count > 0)
            {
                currentId = people.OrderByDescending(x => x.Id).First().Id + 1;
            }
            person.Id = currentId;
            people.Add(person);
            people.SaveToPersonFile(PersonFile);
            return person;
        }

        public List<PersonModel> GetPerson_All()
        {
            return PersonFile.FullFilePath().LoadFile().ConvertToPersonModels();
        }

        public TeamModel CreateTeam(TeamModel model)
        {
            List<TeamModel> teams = TeamFile.FullFilePath().LoadFile().ConvertToTeamModels(PersonFile);

            int currentId = 1;
            if (teams.Count > 0)
            {
                currentId = teams.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentId;
            teams.Add(model);
            teams.SaveToTeamsFile(TeamFile);
            return model;
        }
    }
}
