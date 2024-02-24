using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project4_Phase4.Models
{
    [Table("Student")]
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        
        public int RoolNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
    }
}
