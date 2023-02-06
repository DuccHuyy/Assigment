using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practice_1.Models
{
    public class Exam
    {
        public long ExamId { get; set; }

        [Required]
        [Range(0, 100)]
        public int Score { get; set;}

        [ForeignKey("StudentId")]
        public long StudentId { get; set; }

        [ForeignKey("SubjectId")]
        public int SubjectId { get; set; }

        public Student? student { get; set; }

        public Subject? subject { get; set; }
    }
}
