using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace InputAsp.Models
{
    public class Applicant
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        [Required]
        [StringLength(10)]
        public string Gender { get; set; }

        [Required]
        [Range(25,55, ErrorMessage = "Kamu esempe")]
        [DisplayName("Age in Years")]
        public int Age { get; set;}

        [Required]
        [StringLength(50)]
        public string Qualification { get; set; }

        [Required]
        [Range(1,25, ErrorMessage = "Kurang berpengalaman")]
        [DisplayName("Total Experience In Years")]
        public int TotalExperience { get; set; }
        public virtual List<Experience> Experiences { get; set; } = new List<Experience>(); // detail list Experience akan berada disini
    }
}
