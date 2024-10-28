using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TRUJILLOISAAC_EXAMENP1.Models
{
    public class Celular
    {
        [Required]
        public int Idceluar { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string modelo { get; set; }
        [Required]

        public DateOnly año { get; set; }
        public double precio { get; set; }
        [ForeignKey("IdUsuario")]
        public int IdUsusario { get; set; }


    }
}
