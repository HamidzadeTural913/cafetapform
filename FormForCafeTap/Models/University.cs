using System.ComponentModel.DataAnnotations;

namespace FormForCafeTap.Models
{
    public class University
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Tələb olunan hissə doldurulmalıdır!")]
        public string Name { get; set; }
    }
}
