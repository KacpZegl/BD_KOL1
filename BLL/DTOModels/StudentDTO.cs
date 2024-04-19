using System;

namespace BLL.DTOModels
{
    public class StudentDTO
    {
        public int ID { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int? GroupID { get; set; }
    }
}
