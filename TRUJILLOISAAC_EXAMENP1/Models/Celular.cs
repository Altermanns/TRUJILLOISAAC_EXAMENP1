using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TRUJILLOISAAC_EXAMENP1.Models
{
    public class Celular
    {
        [Required]
        [Key]
        public int Idceluar { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string modelo { get; set; }
        [Required]
        public int año { get; set; }
        public double precio { get; set; }
        
            

    }
}
