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
        [RegularExpression(@"^(([A-za-z]+[\s]{1}[A-za-z]+)|([A-Za-z]+))$", ErrorMessage = "Por favor introduza um Nome válido!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Por favor introduza uma Descrição!")]
        [StringLength(256)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z'\s]*$", ErrorMessage = "Por favor introduza uma Descrição válida!")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Por favor introduza uma Localização!")]
        [Display(Name = "Home Phone")]
        [StringLength(256)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z'\s]*$", ErrorMessage = "Por favor introduza uma Localização válida!")]
        public string Localizacao { get; set; }
    }
}
