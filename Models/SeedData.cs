using System.Linq;

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
                new Funcionario { Nome = "André Alberto", Telemovel = "962108458", Email = "andrealb_45@gmail.com", Servico = "Bar ESTG" },
                new Funcionario { Nome = "João Dias", Telemovel = "913409571", Email = "joao.dias56@gmail.com", Servico = "Direção ESTG" },
                new Funcionario { Nome = "Vita", Telemovel = "962108458", Email = "joao.dias56@gmail.com", Servico = "Direção IPG" },
                new Funcionario { Nome = "Francisco Cordeiro", Telemovel = "930912764", Email = "xicokiko23@gmail.com", Servico = "Direção ESCED" },
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
                new Servico { Nome = "Direção ESTG", Descricao = "", Localizacao = "ESTG" },
                new Servico { Nome = "Direção ESCED", Descricao = "", Localizacao = "ESCED" },
                new Servico { Nome = "Direção IPG", Descricao = "", Localizacao = "Serviços Centrais" },
                new Servico { Nome = "Bar ESTG", Descricao = "", Localizacao = "ESTG" }
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