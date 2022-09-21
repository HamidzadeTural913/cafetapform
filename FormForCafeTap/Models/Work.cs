using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FormForCafeTap.Models
{
    public class Work
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Tələb olunan hissə doldurulmalıdır!")]
        public string Name { get; set; }
        public List<Form> Forms { get; set; }
    }
}
