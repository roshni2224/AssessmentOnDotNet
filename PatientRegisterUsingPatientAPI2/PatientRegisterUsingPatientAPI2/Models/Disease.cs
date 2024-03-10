using System.ComponentModel.DataAnnotations;

namespace PatientRegisterUsingPatientAPI2.Models
{
    public class Disease
    {
        [Key]
        public int DiseaseId { get; set; }

        public string DiseaseName { get; set; }
    }
}
