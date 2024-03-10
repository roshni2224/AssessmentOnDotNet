using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PatientRegisterUsingPatientAPI2.Models
{
    public class PatientInformation
    {
        [Key]
        public int PatientId { get; set; }

        [Required]
        public string PatientName { get; set; }
        [Required]
        public string DiseaseName { get; set; }
        [Required]
        public string Epilepsy {  get; set; }

        public string NCD { get; set; }

        public string Allergies { get; set; } 
    }
}
