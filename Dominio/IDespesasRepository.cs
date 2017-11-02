using System.Collections.Generic;
namespace finlab.Dominio
{
    public interface IDespesasRepository
    {
         void Create(Despesas despesas);
         void Update(Despesas despesas);
         void Delete(int id);

         List<Despesas>GetAll();

         Despesas GetById(int id);


    }
}