using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoTarefasIPG.Models
{
    public class Servico
    {
        public int ServicoId { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public string Localizacao { get; set; }
    }
}
