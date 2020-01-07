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
               new Professor { Nome = "Capitolino Andrioleto", Email = "capandr12@gmail.com", Telemovel = "964587523", Numero_De_Professor = "1", Numero_De_Gabinete = "1" },
               new Professor { Nome = "Jusefino Correia", Email = "jusecorreia23@hotmail.com", Telemovel = "925418781", Numero_De_Professor = "2", Numero_De_Gabinete = "2" },
               new Professor { Nome = "Albertina Barata", Email = "albabara146@sapo.pt", Telemovel = "934124960", Numero_De_Professor = "3", Numero_De_Gabinete = "3" },
               new Professor { Nome = "Eusébio Amaro", Email = "eusebamaro_345@outlook.com", Telemovel = "913215005", Numero_De_Professor = "4", Numero_De_Gabinete = "4" }
                );
            db.SaveChanges();
        }


    }
}