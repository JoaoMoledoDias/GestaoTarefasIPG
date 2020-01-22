using Microsoft.AspNetCore.Identity;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoTarefasIPG.Models
{
    public class SeedData
    {

        //O admin tem comtrolo total do site 
        //private const string ADMIN_ROLE = "admin";

        //A distribuição de tarefas tem de ser por hierarquias e que deve ter as premições para poder ter as tarefas
        //e mexer no site
        
        /*private const string PRESIDENTE_ROLE  = "presidente";
        private const string DIRETOR_ROLE = "diretor";
        private const string SECRETARIA_ROLE = "secretaria";
        private const string PROFESSOR_ROLE = "professor";
        private const string FUNCIONARIO_ROLE = "funcionario";*/


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
                new Funcionario { Nome = "Francisco Cordeiro", Telemovel = "930912764", Email = "xicokiko23@gmail.com", Servico = "Direção ESCED" }
                );

            db.SaveChanges();
        }

        /*public static async Task PopulateUsersAsync(UserManager<IdentityUser> userManager)
        {
            const string ADMIN_USERNAME = "admin@ipg.pt";
            const string ADMIN_PASSWORD = "Admin@123$";

            IdentityUser user = await userManager.FindByNameAsync(ADMIN_USERNAME);
            if (user == null)
            {
                user = new IdentityUser
                {
                    UserName = ADMIN_USERNAME,
                    Email = ADMIN_USERNAME
                };

                await userManager.CreateAsync(user, ADMIN_PASSWORD);
            }

            if (!await userManager.IsInRoleAsync(user, ADMIN_ROLE))
            {
                await userManager.AddToRoleAsync(user, ADMIN_ROLE);
            }
        }*/


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
               new Professor { Nome = "Eusébio Amaro", Email = "eusebamaro_345@outlook.com", Telemovel = "913215005", Numero_De_Professor = "4", Numero_De_Gabinete = "4" },
               new Professor { Nome = "João Antunes", Email = "antu_joao_3@hotmail.com", Telemovel = "913235005", Numero_De_Professor = "5", Numero_De_Gabinete = "5" },
               new Professor { Nome = "Pedro José", Email = "josepedro@gmail.com", Telemovel = "934676005", Numero_De_Professor = "6", Numero_De_Gabinete = "6" },
               new Professor { Nome = "Ana Maria", Email = "maria_ana@hotmail.com", Telemovel = "924539075", Numero_De_Professor = "7", Numero_De_Gabinete = "7" },
               new Professor { Nome = "José António", Email = "antonio_jose@sapo.pt", Telemovel = "967349560", Numero_De_Professor = "8", Numero_De_Gabinete = "8" },
               new Professor { Nome = "Amaro Dias", Email = "ama_dias23@outlook.com", Telemovel = "920947234", Numero_De_Professor = "9", Numero_De_Gabinete = "9" },
               new Professor { Nome = "Eduardo  Pereira", Email = "eudpereira_5@outlook.com", Telemovel = "923618459", Numero_De_Professor = "10", Numero_De_Gabinete = "10" }
               );
            db.SaveChanges();
        }
    }
   /* public static async Task CreateRolesAsync(RoleManager<IdentityRole> roleManager)
    {
        //const string CAN_ADD_MENUS = "can_add_menus";

        if (!await roleManager.RoleExistsAsync(ADMIN_ROLE))
        {
            await roleManager.CreateAsync(new IdentityRole(ADMIN_ROLE));
        }

        if (!await roleManager.RoleExistsAsync(SECRETARY_ROLE))
        {
            await roleManager.CreateAsync(new IdentityRole(SECRETARY_ROLE));
        }

        if (!await roleManager.RoleExistsAsync(CLEANING_ROLE))
        {
            await roleManager.CreateAsync(new IdentityRole(CLEANING_ROLE));
        }
    }*/
}