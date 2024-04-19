using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class Student
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Imię jest wymagane")]
        public string Imie { get; set; }

        [Required(ErrorMessage = "Nazwisko jest wymagane")]
        public string Nazwisko { get; set; }

        public int? IDGrupy { get; set; } // Opcjonalny klucz obcy

        [ForeignKey("IDGrupy")]
        public virtual Grupa Grupa { get; set; } // Właściwość nawigacyjna
    }
}
