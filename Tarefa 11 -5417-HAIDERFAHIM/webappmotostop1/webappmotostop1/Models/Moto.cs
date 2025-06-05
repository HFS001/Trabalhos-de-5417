using System.ComponentModel.DataAnnotations;

namespace webappmotostop1.Models
{
    public class Moto
    {
        public int Id { get; set; }

        [Required]
        public string Brand { get; set; } = string.Empty;

        [Required]
        public string Model { get; set; } = string.Empty;

        [Required]
        public string Condition { get; set; } = string.Empty;

        [Required]
        public string LicensePlateNumber { get; set; } = string.Empty;

        [Required]
        public int Year { get; set; }

        [Range(0.0, 100000.0)]
        public decimal Price { get; set; }
    }
}