using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PatientRegisterUsingPatientAPI2.Models
{
    public class NCD_details
    {
        [Key]
        public int ID { get; set; }

        public int PatientId { get; set; }

        public int NCDId { get; set; }

        //[ForeignKey(nameof(NCDId))]
        //[InverseProperty(nameof(NCD.NCD_details))]    
        //public virtual NCD NCD { get; set; }

        //[ForeignKey(nameof(PatientId))]
        //[InverseProperty("NCD_details")]
        //public virtual PatientModel PatientModel { get; set; }


    }
}
