using System.ComponentModel.DataAnnotations;

namespace PatientAPI2.Models
{
    public class Patient
    {
        [Key]
        public Guid PatientID { get; set; }

        public string PatientName { get; set; }

        public string DiseaseInformation { get; set; }

        public string Epilepsy { get; set; }


    }
}
