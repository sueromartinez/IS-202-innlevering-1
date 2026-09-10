using System.ComponentModel.DataAnnotations;

namespace FirstWebAppInDocker.Models
{
    public class PositionModel
    {
        [Required]
        public double Latitude { get; set; }

        [Required]
        public double Longitude { get; set; }

        [Required]
        public string Description { get; set; }
    }
}