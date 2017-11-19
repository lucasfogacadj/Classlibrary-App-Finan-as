using System.Collections.Generic;
using System.Linq;
using finlab.Dominio;

namespace finlab.Repositorio
{
    public class CityRepository : ICityRepository
    {
        private readonly DataContext context;
        public CityRepository(DataContext context)
        {
            this.context = context;
        }

        public List<City> GetAll()
        {
            return context.Cities.ToList();
        }

        public City GetById(int id)
        {
            return context.Cities.Find(id);
}
    }
}