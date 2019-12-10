using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GestaoTarefasIPG.Models
{
    public class TarefasIPGDbContext : DbContext
    {
        public TarefasIPGDbContext(DbContextOptions<TarefasIPGDbContext> options)
            : base(options)
        { }

        public DbSet<GestaoTarefasIPG.Models.Funcionario> Funcionario { get; set; }
        
        public DbSet<GestaoTarefasIPG.Models.Professor> Professor { get; set; }
    }
}

