using System.ComponentModel.DataAnnotations;

namespace webappmotostop1.Models
{
    public class Moto
    {
        public int Id { get; set; }

        [Required]
        public string Brand { get; set; }

        [Required]
        public string Model { get; set; }

        public int Year { get; set; }

        public string? Condition { get; set; }

        public string? LicensePlateNumber { get; set; }

        public decimal Price { get; set; }
    }
}