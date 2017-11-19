using System.Collections.Generic;

namespace finlab.Dominio
{
    public interface ICityRepository
    {
           List<City>GetAll();
            City GetById(int id);
    }
}