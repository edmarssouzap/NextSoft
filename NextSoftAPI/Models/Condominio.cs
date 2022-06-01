using System.ComponentModel.DataAnnotations;

namespace NextSoftAPI.Models
{
    public class Condominio
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Nome é requerido.")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "O campo Nome aceita minimo de 1 e máximo de 100 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo Bairro é requerido.")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "O campo Bairro aceita minimo de 1 e máximo de 100 caracteres.")]
        public string Bairro { get; set; }
    }
}
