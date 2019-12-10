using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GestaoTarefasIPG.Models
{
    public class ServicoContext : DbContext
    {
        public ServicoContext (DbContextOptions<ServicoContext> options)
            : base(options)
        {
        }

        public DbSet<GestaoTarefasIPG.Models.Servico> Servico { get; set; }
    }
}
