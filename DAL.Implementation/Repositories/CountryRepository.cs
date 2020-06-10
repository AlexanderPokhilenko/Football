using System.Linq;
using DAL.Abstract.Repositories;
using DAL.Entities;

namespace DAL.Implementation.Repositories
{
    public class CountryRepository : AbstractRepository<int, Country>, ICountryRepository
    {
        public CountryRepository(ApplicationContext context) : base(context)
        { }

        public Country GetByName(string name)
        {
            return Db.Countries.First(country => country.Name == name);
        }
    }
}