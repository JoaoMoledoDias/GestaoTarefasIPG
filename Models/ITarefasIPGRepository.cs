using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoTarefasIPG.Models{
    
    public interface ITarefasIPGRepository {
    
        IEnumerable<Professor> Professor { get; }
        IEnumerable<Funcionario> Funcionario { get; }
        IEnumerable<Servico> Servico { get; }

    }
}
