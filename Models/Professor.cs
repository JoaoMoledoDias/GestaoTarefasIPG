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

        [StringLength(100)]
        [Display(Name = "Nome professor")]
        [Required(ErrorMessage = "Por favor introduza um Nome!")]
        public string Nome { get; set; }

        [StringLength(80)]
        [Display(Name = "Emaile do professor")]
        [Required(ErrorMessage = "Por favor introduza um Email!")]
        public string Email { get; set; }

        [StringLength(9)]
        [Display(Name = "Número de telemovel")]
        [Required(ErrorMessage = "Por favor introduza um Número de telemóvel!")]
        public string Telemovel { get; set; }

        [StringLength(9)]
        [Display(Name = "Número de professor")]
        [Required(ErrorMessage = "Por favor introduza um Número de Professor!")]
        public string Numero_De_Professor { get; set; }

        [StringLength(2)]
        [Display(Name = "Número de gabinete")]
        [Required(ErrorMessage = "Por favor introduza um Número de Gabinete!")]
        public string Numero_De_Gabinete { get; set; }

    }
}
