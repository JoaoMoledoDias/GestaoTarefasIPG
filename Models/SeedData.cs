using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoTarefasIPG.Models
{
    public class SeedData
    {
        public static void Populate(TarefasIPGDbContext db)
        {
            PopulateFuncionario(db);
            PopulateServico(db);
            PopulateProfessor(db);
        }
        private static void PopulateFuncionario(TarefasIPGDbContext db)
        {
            if (db.Funcionario.Any())
            {
                return;
            }
            db.Funcionario.AddRange(
                new Funcionario { Nome = "", Telemovel = "", Email = "", Servico = "" },
                new Funcionario { Nome = "", Telemovel = "", Email = "", Servico = "" },
                new Funcionario { Nome = "", Telemovel = "", Email = "", Servico = "" },
                new Funcionario { Nome = "", Telemovel = "", Email = "", Servico = "" },
                new Funcionario { Nome = "", Telemovel = "", Email = "", Servico = "" },
                new Funcionario { Nome = "", Telemovel = "", Email = "", Servico = "" }
                );

            db.SaveChanges();
        }
        private static void PopulateServico(TarefasIPGDbContext db)
        {
            if (db.Servico.Any())
            {
                return;
            }
            db.Servico.AddRange(
                new Servico { Nome = "", Descricao = "", Localizacao = "" },
                new Servico { Nome = "", Descricao = "", Localizacao = "" },
                new Servico { Nome = "", Descricao = "", Localizacao = "" }
                );

            db.SaveChanges();
        }

        private static void PopulateProfessor(TarefasIPGDbContext db)
        {
            if (db.Professor.Any())
            {
                return;
            }
            db.Professor.AddRange(
               new Professor { Nome = "", Email = "", Telemovel = "", Numero_De_Gabinete = "", Numero_De_Professor = "" },
               new Professor { Nome = "", Email = "", Telemovel = "", Numero_De_Gabinete = "", Numero_De_Professor = "" },
               new Professor { Nome = "", Email = "", Telemovel = "", Numero_De_Gabinete = "", Numero_De_Professor = "" },
               new Professor { Nome = "", Email = "", Telemovel = "", Numero_De_Gabinete = "", Numero_De_Professor = "" },
               new Professor { Nome = "", Email = "", Telemovel = "", Numero_De_Gabinete = "", Numero_De_Professor = "" },
               new Professor { Nome = "", Email = "", Telemovel = "", Numero_De_Gabinete = "", Numero_De_Professor = "" },
               new Professor { Nome = "", Email = "", Telemovel = "", Numero_De_Gabinete = "", Numero_De_Professor = "" },
               new Professor { Nome = "", Email = "", Telemovel = "", Numero_De_Gabinete = "", Numero_De_Professor = "" },
               new Professor { Nome = "", Email = "", Telemovel = "", Numero_De_Gabinete = "", Numero_De_Professor = "" },
               new Professor { Nome = "", Email = "", Telemovel = "", Numero_De_Gabinete = "", Numero_De_Professor = "" }
                );
            db.SaveChanges();
        }


    }
}