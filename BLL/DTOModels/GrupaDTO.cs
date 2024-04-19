using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOModels
{
    public class GrupaDTO
    {
        public GrupaDTO(int id, string nazwa)
        {
            ID = id;
            Nazwa = nazwa;
        }

        public int ID { get; }
        public string Nazwa { get; }
    }
}
