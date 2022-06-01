using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NextSoftAPI.Models
{
    public class Familia
    {
        [Key]
        public int Id { get; set; }

        [Required (ErrorMessage = "O campo Nome é requerido.")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "O campo Nome aceita minimo de 1 e máximo de 100 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo Nome é requerido.")]
        public int Apto { get; set; }

        [ForeignKey("Condominio")]
        public int Id_Condominio { get; set; }
        public Condominio Condominio { get; set; }
    }
}
