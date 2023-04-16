using ASP_NET.Models;
using Microsoft.AspNetCore.Mvc;
using ASP_NET.Data.Interfaces;

namespace ASP_NET.Data
{
    public class MockRepository : ISchoolRepository
    {
            List<Teacher> Teachers = new List<Teacher>() {
                new Teacher() { TeacherId = 1, FirstName = "mock-Siggi", LastName = "Nonni" },
                new Teacher() { TeacherId = 2, FirstName = "mock-Kalli", LastName = "Steini" },
                new Teacher() { TeacherId = 3, FirstName = "mock-Gunni", LastName = "Stebbi" },
                new Teacher() { TeacherId = 4, FirstName = "mock-Adam", LastName = "Lalli" }
    };

        List<Student> Students = new List<Student>()
        {
            new Student() { StudentId = 1, FirstName = "Mock-Student1", LastName = "Mockson"}
        };

        public List<Teacher> GetAllTeachers()
        {
            return Teachers;

        }

        public List<Student> GetAllStudents()
        {
            return Students;

        }

        public Teacher? GetTeacherById(int id)
        {
            foreach (Teacher teacher in Teachers)
            {

                if (teacher.TeacherId == id)
                {
                    return teacher;
                }
            }

            return null;
        }

        public void CreateTeacher(Teacher teacher)
        {
            throw new NotImplementedException();
        }

        public Teacher? UpdateTeacher(int id, Teacher teacherFromBody)
        {
            throw new NotImplementedException();
        }

        public bool DeleteTeacher(Teacher teacher)
        {
            throw new NotImplementedException();
        }
    }
}

