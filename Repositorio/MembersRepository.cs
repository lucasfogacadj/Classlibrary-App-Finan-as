using System.Collections.Generic;
using System.Linq;
using finlab.Dominio;
using Microsoft.EntityFrameworkCore;
namespace finlab.Repositorio
{
    public class MembersRepository : IMembersRepository
    {
         private DataContext context;
         public MembersRepository(DataContext context)
        {           
            this.context = context;
        }

         public void Create(Members members)
        {
            
            members.city = context.Cities.Find(members.city.Id);

            context.Members.Add(members);
            context.SaveChanges();

        }

        public void Delete(int id)
        {
            context.Members.Remove(context.Members.Find(id));        
            context.SaveChanges();
        }

        public void Update(Members member)
        {
            context.Entry(member).State = EntityState.Modified;
            context.SaveChanges();
        }

        public Members GetById(int id)
        {
            return context.Members.Include(x=>x.city).SingleOrDefault(x=>x.Id == id);
        }
        public List<Members> GetAll()
        {
            return context.Members.Include(x => x.city).ToList();
        }
    }
}