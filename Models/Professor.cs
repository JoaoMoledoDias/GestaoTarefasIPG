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
        
        [Required(ErrorMessage = "Por favor introduza um Nome!")]
        public string Nome { get; set; }
        
        [Required(ErrorMessage = "Por favor introduza um Email!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Por favor introduza um Número de telemóvel!")]
        public string Telemovel { get; set; }

        [Required(ErrorMessage = "Por favor introduza um Número de Professor!")]
        public string Numero_De_Professor { get; set; }

        [Required(ErrorMessage = "Por favor introduza um Número de Gabinete!")]
        public string Numero_De_Gabinete { get; set; }

    }
}
