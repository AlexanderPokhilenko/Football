using System.Collections.Generic;
using DTO;

namespace BLL.Abstract
{
    public interface ITeamService
    {
        void AddTeam(TeamDto t);
        IEnumerable<TeamDto> GetTeams();
    }
}