using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho.Contexto
{
    class AgendaContexto: DbContext
    {
        public AgendaContexto() : base(nameOrConnectionString: "agenda")
        {
            Database.SetInitializer<AgendaContexto>(new AgendaContextoInitialize());        
        }
        public DbSet<Pessoa> Pesssoas { get; set; }
        public class AgendaContextoInitialize : DropCreateDatabaseAlways<AgendaContexto>
        {

        }
    }
    
}
