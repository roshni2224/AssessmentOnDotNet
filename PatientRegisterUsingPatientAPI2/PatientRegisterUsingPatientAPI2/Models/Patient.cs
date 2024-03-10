using System.ComponentModel.DataAnnotations;

namespace PatientRegisterUsingPatientAPI2.Models
{
    public class Patient
    {
        public  Guid patientID { get; set; }
        [Required]
        public string patientName { get; set; }
        [Required]
        public string diseaseInformation { get; set; }
        [Required]
        public string epilepsy { get; set; }
    }
}


