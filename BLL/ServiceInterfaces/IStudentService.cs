using BLL.DTOModels;

namespace BLL.ServiceInterfaces
{
    public interface IStudentService
    {
        void AddStudent(StudentDTO studentDto);
        StudentDTO GetStudent(int studentId);
        void UpdateStudent(StudentDTO studentDto);
        void DeleteStudent(int studentId);
    }
}
