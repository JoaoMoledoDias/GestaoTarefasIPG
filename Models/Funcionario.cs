using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoTarefasIPG.Models
{
    public class Funcionario
    {
        public int FuncionarioId { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Nome { get; set; }

        public string Servico { get; set; }

        [RegularExpression(@"(\w+(\.\w+)*@[a-zA-Z_]+?\.[a-zA-Z]{2,6})", ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }

        public string Telemovel { get; set; }
    }
}
