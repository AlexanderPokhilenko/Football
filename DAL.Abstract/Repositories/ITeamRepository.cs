using DAL.Entities;

namespace DAL.Abstract.Repositories
{
    public interface ITeamRepository : IRepository<int, Team>
    {
        Team GetByName(string name);
    }
}