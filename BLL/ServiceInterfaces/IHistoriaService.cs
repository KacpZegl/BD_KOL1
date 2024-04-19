using BLL.DTOModels;

namespace BLL.ServiceInterfaces
{
    public interface IHistoriaService
    {
        void AddHistoria(HistoriaDTO historiaDto);
        IEnumerable<HistoriaDTO> GetAllHistoria();
        IEnumerable<HistoriaDTO> GetHistoriaPage(int pageNumber, int pageSize);
    }
}
