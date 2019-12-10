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
        public string Nome { get; set; }

        [Required(ErrorMessage = "Por favor introduza uma Descrição!")]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "Por favor introduza uma Localização!")]
        public string Localizacao { get; set; }
    }
}
