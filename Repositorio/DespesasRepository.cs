using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using finlab.Dominio;

namespace finlab.Repositorio
{
    public class DespesasRepository : IDespesasRepository
    {
        private DataContext context;

        public DespesasRepository(DataContext context)
        {
            this.context = context;
        }

        public void Create(Despesas despesas)
        {
            context.Gasto.Add(despesas);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            context.Gasto.Remove(GetById(id));
            context.SaveChanges();
        }

        public void Update(Despesas despesas)
        {
            context.Entry(despesas).State = EntityState.Modified;
            context.SaveChanges();
        }

        public Despesas GetById(int id)
        {
            return context.Gasto.SingleOrDefault(x =>x.id == id);
        }

        public List<Despesas> GetAll()
        {
            return context.Gasto.ToList();
        }

    }
}