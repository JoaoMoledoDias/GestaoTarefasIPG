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
        [StringLength(50, MinimumLength = 3)]
        [RegularExpression(@"(\w+(\.\w+)*@[a-zA-Z_]+?\.[a-zA-Z]{2,6})", ErrorMessage = "Por favor introduza um Nome válido!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Por favor introduza uma Descrição!")]
        [StringLength(256)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z'\s]*$", ErrorMessage = "Por favor introduza uma Descrição válido!")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Por favor introduza uma Localização!")]
        [StringLength(256)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z'\s]*$", ErrorMessage = "Por favor introduza uma Localização válido!")]
        public string Localizacao { get; set; }
    }
}
