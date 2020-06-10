using DAL.Abstract.Repositories;
using DAL.Entities;

namespace DAL.Implementation.Repositories
{
    public class TournamentRepository : AbstractRepository<int, Tournament>, ITournamentRepository
    {
        public TournamentRepository(ApplicationContext context) : base(context)
        { }
    }
}