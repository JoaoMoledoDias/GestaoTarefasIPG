using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoTarefasIPG.Models
{
    public class Servico
    {
        public int ServicoId { get; set; }

        [Required(ErrorMessage = "Por favor introduza um Nome!")]
        [StringLength(50,ErrorMessage ="O Nome terá que conter no mínimo 3 caracteres válidos (A-Z)", MinimumLength = 3)]
        [RegularExpression(@"^[a-zA-ZÀ-ÿ]*$", ErrorMessage = "Por favor introduza um Nome válido!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Por favor introduza uma Descrição!")]
        [StringLength(50, ErrorMessage = "A Descrição terá que conter no mínimo 3 caracteres válidos (A-Z)", MinimumLength = 3)]
        [RegularExpression(@"^[a-zA-ZÀ-ÿ]*$", ErrorMessage = "Por favor introduza uma Descrição válida!")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Por favor introduza uma Localização!")]
        [StringLength(50, ErrorMessage = "A Localização terá que conter no mínimo 3 caracteres válidos (A-Z)", MinimumLength = 3)]
        [RegularExpression(@"^[a-zA-ZÀ-ÿ]*$", ErrorMessage = "Por favor introduza uma Localização válida!")]
        public string Localizacao { get; set; }
    }
}
