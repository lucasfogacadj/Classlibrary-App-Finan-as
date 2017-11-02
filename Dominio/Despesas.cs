namespace finlab.Dominio
{
    public class Despesas
    {
        public int  id { get; set; }

        public string data { get; set; }
        
        public decimal numDoc { get; set; }
        
        public string grupo { get; set; }

        public string local { get; set; }
        

        public Despesas(int id, string  data, decimal numDoc, string grupo, string local)
        {
            this.id = id;
            this.data = data;
            this.numDoc = numDoc;
            this.grupo = grupo;
            this.local = local;
        }
        
    }
}