using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoTarefasIPG.Models
{
    public class FakeRepository : ITarefasIPGRepository
    {
        public IEnumerable<Professor> Professor => new List<Professor> { 

            new Professor {Nome="", Email="", Telemovel="", Numero_De_Professor="", Numero_De_Gabinete=""}

        };

        public IEnumerable<Funcionario> Funcionario => new List<Funcionario> { 
        
            new Funcionario {Nome="", Email="", Telemovel="", Servico=""}

        };

        public IEnumerable<Servico> Servico => new List<Servico> {
        
            new Servico{Nome="", Descricao="", Localizacao=""}

        };


    }
}
