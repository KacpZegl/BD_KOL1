using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class Student
    {
        [Key]
        public int ID { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }

        public int? GroupaID { get; set; }
        [ForeignKey("GroupaID")]
        public Grupa Grupa { get; set; }
    }
}
