using System.ComponentModel.DataAnnotations;

namespace FormForCafeTap.Models
{
    public class Form
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Tələb olunan hissə doldurulmalıdır!")]
        public string Fullname { get; set; }

        [Required(ErrorMessage = "Tələb olunan hissə doldurulmalıdır!")]
        public int PhoneNumber { get; set; }

        [Required(ErrorMessage ="Tələb olunan hissə doldurulmalıdır!"),DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Tələb olunan hissə doldurulmalıdır!")]
        public int Age { get; set; }
        public string Message { get; set; }

        public int WorkId { get; set; }
        public Work Work { get; set; }

        public int UniversityId { get; set; }

        public University Uni { get; set; }


    }
}
