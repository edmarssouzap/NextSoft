using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NextSoftAPI.Models
{
    public class Morador
    {
        [Key]
        public int Id { get; set; }

        [Required (ErrorMessage = "O campo Nome não pode ser nulo.")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "O campo Nome aceita minimo de 1 e máximo de 100 caracteres.")]
        public string Nome { get; set; }

        [Required]
        public int Idade { get; set; }

        [ForeignKey("Familia")]
        public int Id_Familia { get; set; }
        public Familia Familia { get; set; }
    }
}
