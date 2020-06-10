using DAL.Entities;

namespace DAL.Abstract.Repositories
{
    public interface ICountryRepository : IRepository<int, Country>
    {
        Country GetByName(string name);
    }
}