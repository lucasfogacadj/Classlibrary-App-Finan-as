using System.Collections.Generic;

namespace finlab.Dominio
{
    public class City
    {
        public int Id { get; set; }
        public string name { get; set; }

        public virtual IEnumerable<Members> Members{get; set;}
        
    }
}