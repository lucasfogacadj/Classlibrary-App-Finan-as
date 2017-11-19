using System.Collections.Generic;
namespace finlab.Dominio
{
    public interface IMembersRepository
    {
        
         void Create(Members member);
         void Update(Members member);
         void Delete(int id);
         List<Members>GetAll();
         Members GetById(int id);

    }
}