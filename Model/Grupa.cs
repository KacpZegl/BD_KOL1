using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;


namespace Model
{
    public class Grupa
    {
        [Key]
        public int ID { get; set; }
        public string Nazwa { get; set; }

        public virtual ICollection<Student> Studenci { get; set; } = new HashSet<Student>(); // Kolekcja studentów
    }
}
