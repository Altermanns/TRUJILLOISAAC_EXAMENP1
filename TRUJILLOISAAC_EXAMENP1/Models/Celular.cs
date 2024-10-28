using System.ComponentModel.DataAnnotations;

namespace TRUJILLOISAAC_EXAMENP1.Models
{
    public class Celular
    {
        [Required]
        public int Idceluar { get; set; }
        [Required]
        [MaxLength(100)]
        public string modelo { get; set; }
        [Required]
        public DateOnly año { get; set; }
        public double precio { get; set; }

    }
}
