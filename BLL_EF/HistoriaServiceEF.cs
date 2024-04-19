using BLL.DTOModels;
using BLL.ServiceInterfaces;
using DAL;
using Model;
using System.Collections.Generic;
using System.Linq;

namespace BLL_EF
{
    public class HistoriaServiceEF : IHistoriaService // Dodajemy implementację interfejsu
    {
        private readonly SchoolContext _context;

        public HistoriaServiceEF(SchoolContext context)
        {
            _context = context;
        }

        public void AddHistoria(HistoriaDTO historiaDto)
        {
            var historia = new Historia
            {
                Imie = historiaDto.Imie,
                Nazwisko = historiaDto.Nazwisko,
                IdGrupy = historiaDto.IdGrupy,
                TypAkcji = historiaDto.TypAkcji,
                Data = historiaDto.Data
            };
            _context.Historia.Add(historia);
            _context.SaveChanges();
        }

        public IEnumerable<HistoriaDTO> GetAllHistoria()
        {
            return _context.Historia
                .Select(h => new HistoriaDTO
                {
                    ID = h.ID,
                    Imie = h.Imie,
                    Nazwisko = h.Nazwisko,
                    IdGrupy = h.IdGrupy,
                    TypAkcji = h.TypAkcji,
                    Data = h.Data
                })
                .ToList();
        }

        public IEnumerable<HistoriaDTO> GetHistoriaPage(int pageNumber, int pageSize) // Implementacja brakującej metody
        {
            return _context.Historia
                .OrderByDescending(h => h.Data) // Przykładowe sortowanie, możesz dostosować do własnych potrzeb
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .Select(h => new HistoriaDTO
                {
                    ID = h.ID,
                    Imie = h.Imie,
                    Nazwisko = h.Nazwisko,
                    IdGrupy = h.IdGrupy,
                    TypAkcji = h.TypAkcji,
                    Data = h.Data
                })
                .ToList();
        }
    }
}
