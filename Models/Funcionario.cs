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

        [StringLength(50, ErrorMessage = "O Nome terá que conter no mínimo 3 caracteres válidos (A-Z)", MinimumLength = 3)]
        [Required(ErrorMessage = "Por favor introduza o Nome!")]
        [RegularExpression(@"^[a-zA-ZÀ-ÿ]*$", ErrorMessage = "Por favor introduza um Nome válido!")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Por favor introduza o Serviço!")]
        [StringLength(50, ErrorMessage = "O Nome terá que conter no mínimo 3 caracteres válidos (A-Z)", MinimumLength = 3)]
        public string Servico { get; set; }
        [Required(ErrorMessage = "Por favor introduza o Email!")]
        [RegularExpression(@"^[a-zA-ZÀ-ÿ]*$", ErrorMessage = "Por favor introduza um email válido ")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Por favor introduza o Telemovel! ")]
        [RegularExpression(@"^?([0-9]{3})?([0−9]3)?[-. ]?([0-9]{3})[-. ]?([0-9]{3})$", ErrorMessage ="Por favor intruduza o numero correto")]
        public string Telemovel { get; set; }
    }
}
