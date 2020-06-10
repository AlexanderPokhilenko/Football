using System.Linq;
using DAL.Abstract.Repositories;
using DAL.Entities;

namespace DAL.Implementation.Repositories
{
    public class TeamRepository : AbstractRepository<int, Team>, ITeamRepository
    {
        public TeamRepository(ApplicationContext context) : base(context)
        { }

        public Team GetByName(string name)
        {
            return Db.Teams.First(team => team.Name == name);
        }
    }
}