using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace InputAsp.Models
{
    public class Experience
    {
        [Key]
        public int ExperienceId { get; set; }

        [ForeignKey("Applicant")] //sambung ke parent model
        public int ApplicantId { get; set; } //ubah tipe data menjadi int
        public virtual Applicant Applicant { get; private set; }
        public string CompanyName { get; set; }
        public string Designation { get; set; }
        [Required]
        public string YearsWorked { get; set; }
    }
}
