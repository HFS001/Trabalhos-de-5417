using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webappmotostop1.Models
{
    public class Client
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [StringLength(9, ErrorMessage = "NIF must be 9 digits only.")]
        public string NIF { get; set; }


        [Required]
        public string Email { get; set; }

        [Required]
        public string Phone { get; set; }
        

        // Foreign key
        [Display(Name = "Motorcycle")]
        public int? MotoId { get; set; }

        // Navigation property
        public Moto? Moto { get; set; }
    }
}