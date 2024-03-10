using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PatientRegisterUsingPatientAPI2.Models
{
    public class NCD
    {
        ////public NCD()
        ////{
        ////    NCD_details = new HashSet<NCD_details>();
        ////}

        [Key]
        public int NCDId { get; set; } 
        public string NCDName { get; set;}

        //[InverseProperty("NCD")]
        //public virtual ICollection<NCD_details> NCD_details { get; set; }
    }
}
