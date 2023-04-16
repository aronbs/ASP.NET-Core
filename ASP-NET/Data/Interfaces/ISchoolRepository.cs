using ASP_NET.Models;

namespace ASP_NET.Data.Interfaces
{
    public interface ISchoolRepository
    {

        List<Teacher> GetAllTeachers();
        List<Student> GetAllStudents();
        Teacher? GetTeacherById(int id);

        bool DeleteTeacher(Teacher teacher);

        void CreateTeacher(Teacher teacher);

        Teacher? UpdateTeacher(int id , Teacher teacherFromBody);

        

    }
}
