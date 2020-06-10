using DAL.Abstract.Repositories;
using DAL.Entities;

namespace DAL.Implementation.Repositories
{
    public class StageRepository : AbstractRepository<int, Stage>, IStageRepository
    {
        public StageRepository(ApplicationContext context) : base(context)
        { }
    }
}