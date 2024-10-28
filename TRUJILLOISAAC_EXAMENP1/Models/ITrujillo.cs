using System.ComponentModel.DataAnnotations;

namespace TRUJILLOISAAC_EXAMENP1.Models
{
    public class ITrujillo
    {
        [Required(ErrorMessage = "Complete este Campo")]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }
        [Required]
        public double numfav { get; set; }
        public bool quierecambiar { get; set; }

    }
}
