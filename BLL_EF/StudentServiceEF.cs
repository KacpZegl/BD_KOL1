using BLL.DTOModels;
using BLL.ServiceInterfaces;
using DAL;
using Model;
using System.Linq;

namespace BLL_EF
{
    public class StudentServiceEF : IStudentService
    {
        private readonly SchoolContext _context;

        public StudentServiceEF(SchoolContext context)
        {
            _context = context;
        }

        public void AddStudent(StudentDTO studentDto)
        {
            var student = new Student
            {
                Imie = studentDto.Imie,
                Nazwisko = studentDto.Nazwisko,
                IDGrupy = studentDto.IDGrupy
            };
            _context.Students.Add(student);
            _context.SaveChanges();
        }

        public StudentDTO GetStudent(int studentId)
        {
            var student = _context.Students.Find(studentId);
            if (student == null) return null;
            return new StudentDTO
            {
                ID = student.ID,
                Imie = student.Imie,
                Nazwisko = student.Nazwisko,
                IDGrupy = student.IDGrupy
            };
        }

        public void UpdateStudent(StudentDTO studentDto)
        {
            var student = _context.Students.Find(studentDto.ID);
            if (student != null)
            {
                student.Imie = studentDto.Imie;
                student.Nazwisko = studentDto.Nazwisko;
                student.IDGrupy = studentDto.IDGrupy;
                _context.SaveChanges();
            }
        }

        public void DeleteStudent(int studentId)
        {
            var student = _context.Students.Find(studentId);
            if (student != null)
            {
                _context.Students.Remove(student);
                _context.SaveChanges();
            }
        }
    }
}
