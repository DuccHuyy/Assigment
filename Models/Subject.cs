using System.ComponentModel.DataAnnotations;

namespace Practice_1.Models
{
    public class Subject
    {
        public int SubjectId { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(20)]
        public string SubjectName { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(20)]
        public string SubjectCode { get; set; }

        [MaxLength(500)]
        public string SubjectDescription { get; set; }

        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{MM/dd/yyyy}")]
        public DateTime StartDate { get; set; }

        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{MM/dd/yyyy}")]
        public DateTime EndDate { get; set; }

        public virtual List<Exam>? Exams { get; set; }

    }
}
