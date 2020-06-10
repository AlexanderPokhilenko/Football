using System;
using System.Collections.Generic;
using BLL.Abstract;
using DAL.Abstract.Repositories;
using DTO;

namespace BLL.Implementation
{
    public class TeamService : ITeamService
    {
        private readonly ITeamRepository teamRep;
        private readonly ICountryRepository countryRep;

        public TeamService(ITeamRepository teamRep, ICountryRepository countryRep)
        {
            this.teamRep = teamRep;
            this.countryRep = countryRep;
        }

        public void AddTeam(TeamDto t)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TeamDto> GetTeams()
        {
            throw new NotImplementedException();
        }
    }
}