using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoTarefasIPG.Models
{
    public class Professor
    {
        public int ProfessorID { get; set; }

        [StringLength(60, MinimumLength = 3, ErrorMessage = "Nome incorreto! Insira um nome válido."), RegularExpression("{A-Z a-z}")]
        public string Nome { get; set; }

        //[]
        public string Email { get; set; }

        //[]
        public string Telemovel { get; set; }

        //[]
        public string Numero_De_Professor { get; set; }

        //[]
        public string Numero_De_Gabinete { get; set; }

        //[]
        public string Unidade_Curricular { get; set; }

    }
}
