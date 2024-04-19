using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class Historia
    {
        [Key]
        public int ID { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }

        public int? GroupID { get; set; }
        [ForeignKey("GroupID")]
        public Grupa Grupa { get; set; }

        public string TypAkcji { get; set; }
        public DateTime Data { get; set; }
    }
}
