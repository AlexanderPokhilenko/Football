using DAL.Abstract.Repositories;
using DAL.Entities;

namespace DAL.Implementation.Repositories
{
    public class StageTypeRepository : AbstractRepository<int, StageType>, IStageTypeRepository
    {
        public StageTypeRepository(ApplicationContext context) : base(context)
        { }
    }
}