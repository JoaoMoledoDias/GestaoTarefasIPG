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

        [Display(Name = "Nome professor")]
        [Required(ErrorMessage = "Por favor introduza um Nome!")]
        [StringLength(50, ErrorMessage = "O Nome terá que conter no mínimo 3 caractéres válidos (A-Z)", MinimumLength = 3)]
        [RegularExpression(@"^(([A-za-z]+[\s]{1}[A-za-z]+)|([A-Za-z]+))$", ErrorMessage = "Por favor introduza um Nome válido!")]
        public string Nome { get; set; }

        [StringLength(80)]
        [Display(Name = "Emaile do professor")]
        [RegularExpression(@"(\w+(\.\w+)*@[a-zA-Z_]+?\.[a-zA-Z]{2,6})", ErrorMessage = "Por favor introduza um email válido ")]
        [Required(ErrorMessage = "Por favor introduza um Email!")]
        public string Email { get; set; }

        [StringLength(9)]
        [Display(Name = "Número de telemovel")]
        [Required(ErrorMessage = "Por favor introduza um Número de telemóvel!")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^?([0-9]{3})?([0−9]3)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Número de telefone invalido!")]
        public string Telemovel { get; set; }

        [StringLength(9)]
        [Display(Name = "Número de professor")]
        [Required(ErrorMessage = "Por favor introduza um Número de Professor!")]
        [RegularExpression(@"^?([0-9]{3})?([0−9]3)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Número de professor invalido!")]
        public string Numero_De_Professor { get; set; }

        [StringLength(2)]
        [Display(Name = "Número de gabinete")]
        [Required(ErrorMessage = "Por favor introduza um Número de Gabinete!")]
        [RegularExpression(@"^?([0-9]{3})?([0−9]3)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Número de gabinete invalido!")]
        public string Numero_De_Gabinete { get; set; }

    }
}
