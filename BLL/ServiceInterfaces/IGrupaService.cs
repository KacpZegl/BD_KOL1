using BLL.DTOModels;

namespace BLL.ServiceInterfaces
{
    public interface IGrupaService
    {
        void AddGrupa(GrupaDTO grupaDto);
        GrupaDTO GetGrupa(int grupaId);
        void UpdateGrupa(GrupaDTO grupaDto);
        void DeleteGrupa(int grupaId);
    }
}
