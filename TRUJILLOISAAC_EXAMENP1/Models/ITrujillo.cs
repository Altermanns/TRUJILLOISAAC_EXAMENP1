using System.ComponentModel.DataAnnotations;

namespace TRUJILLOISAAC_EXAMENP1.Models
{
    public class ITrujillo
    {
        [Required(ErrorMessage = "Complete este Campo")]
        [Key]
        public int IdUsuario { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }
        [Required]
        public double numfav { get; set; }
        [Required]
        public bool quierecambiar { get; set; }

    }
}
