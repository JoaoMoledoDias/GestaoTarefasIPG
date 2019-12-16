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
        [StringLength(100, MinimumLength = 3)]
        public string Nome { get; set; }
        
        [Required(ErrorMessage = "Por favor introduza um Email!")]
        [RegularExpression(@"(\w+(\.\w+)*@[a-zA-Z_]+?\.[a-zA-Z]{0,9})")] 
        public string Email { get; set; }

        [Required(ErrorMessage = "Por favor introduza um Número de telemóvel!")]
        [StringLength(9)]
        public string Telemovel { get; set; }

        [Required(ErrorMessage = "Por favor introduza um Número de Professor!")]
        [StringLength(9)]
        public string Numero_De_Professor { get; set; }

        [Required(ErrorMessage = "Por favor introduza um Número de Gabinete!")]
        [StringLength(2)]
        public string Numero_De_Gabinete { get; set; }

    }
}
