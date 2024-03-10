using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PatientRegisterUsingPatientAPI2.Models
{
    public class Allergies
    {
        //public Allergies()
        //{
        //    Allergies_details = new HashSet<Allergies_details>();
        //}
        [Key]
        public int AllergiesId { get; set; } 
        public int AllergiesName { get; set; }

        //[InverseProperty("Allergies")]
       
        //public virtual ICollection<Allergies_details> Allergies_details { get; set; }
    }
}
