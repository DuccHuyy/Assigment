using System.ComponentModel.DataAnnotations;

namespace Practice_1.Models
{
    public class Student
    {
        public long StudentId { get; set; }

        [Required]
        [MinLength(8)]
        [MaxLength(150)]
        public string Name { get; set; }

        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{MM/dd/yyyy}")]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Address { get; set; }

        public virtual List<Exam>? Exams { get; set; }

    }
}
