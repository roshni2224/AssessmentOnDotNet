using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PatientRegisterUsingPatientAPI2.Models
{
    public class Allergies_details
    {
        [Key]
        public int ID { get; set; }

        public int PatientId { get; set; }

        public int AllergiesId { get; set; }



        //[ForeignKey(nameof(AllergiesId))]
        //[InverseProperty(nameof(Allergies.Allergies_details))]
        //public virtual Allergies Allergies { get; set; }

        //[ForeignKey(nameof(PatientId))]
        //[InverseProperty("Allergies_details")]
        //public virtual PatientModel PatientModel { get; set; }

    }
}
