using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PatientRegisterUsingPatientAPI2.Models
{
    public class PatientModel
    {
        public PatientModel()
        {
            NCD_details = new HashSet<NCD_details>();
            Allergies_details = new HashSet<Allergies_details>();

        }
        [Key]
        public int PatientId { get; set; }

        [Required]
        public string PatientName { get; set; }
        [Required]
        public List<SelectListItem> DiseaseName { get; set;}
        [Required]
        public Enum Epilepsy;

        [InverseProperty("PatientModel")]
        public virtual ICollection<NCD_details> NCD_details { get; set; }
        [InverseProperty("PatientModel")]
        [Required]
        public virtual ICollection<Allergies_details> Allergies_details { get; set; }
    }
}
