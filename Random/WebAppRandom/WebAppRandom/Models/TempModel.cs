using System.ComponentModel.DataAnnotations;

namespace WebAppRandom.Models
{
    public class TempModel
    {
        [Required(ErrorMessage = "Temperature value is required.")]
        [Range(-100, 100, ErrorMessage = "Temperature value must be between -100 and 100.")]

        public double Value { get; set; }
        public string Scale { get; set; } // C or F
        public string ConvertToScale { get; set; }

        public double ConvertedValue { get; set; }
    }
}
