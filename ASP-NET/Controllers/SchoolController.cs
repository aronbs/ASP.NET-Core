using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ASP_NET.Models;
using ASP_NET.Data;
using ASP_NET.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ASP_NET.Controllers
{
    [Route("api")]
    [ApiController]
    public class SchoolController : ControllerBase
    {

        private ISchoolRepository _repo;

        public SchoolController(ISchoolRepository repo)
        {
            _repo = repo;
        }


        [HttpGet]
        [Route("teachers")]
        public List<Teacher> GetAllTeachers()
        {
            return _repo.GetAllTeachers();

        }

        [HttpGet]
        [Route("teachers/{id}")]
        public ActionResult<TeacherDTO> GetTeacherById(int id)
        {

            try
            {
                Teacher? teacher = _repo.GetTeacherById(id);

                if (teacher == null)
                {
                    return NotFound();

                }

                TeacherDTO teacherDTO = new TeacherDTO() { FirstName = teacher.FirstName, Subjects = teacher.Subjects };

                return teacherDTO;
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpDelete]
        [Route("teachers/{id}")]
        public ActionResult<bool> DeleteTeacherById(int id)
        {

            try
            {
                Teacher? teacher = _repo.GetTeacherById(id);

                if (teacher == null)
                {
                    return NotFound();

                }

                bool success = _repo.DeleteTeacher(teacher);

                if (!success)
                {
                    return StatusCode(500);
                }

                return Ok();

            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }




        [HttpPost]
        [Route("teachers")]
        public ActionResult<Teacher> CreateTeacher(Teacher teacher)
        {
            try
            {
                _repo.CreateTeacher(teacher);


                //    return CreatedAtAction("GetTodoItem", new { id = todoItem.Id }, todoItem);
                return CreatedAtAction(nameof(GetTeacherById), new { id = teacher.TeacherId }, teacher);
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPut]
        [Route("teachers/{id}")]
        public IActionResult UpdateTeacher(int id, Teacher teacherFromBody)
        {
            if (id != teacherFromBody.TeacherId)
            {
                return BadRequest();
            }

            try
            {
                Teacher? updated = _repo.UpdateTeacher(id, teacherFromBody);

                if (updated == null)
                {
                    return NotFound();
                }

                return NoContent();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

        }



        [HttpGet]
        [Route("students")]
        public List<Student> GetAllStudents()
        {
            return _repo.GetAllStudents();

        }

    }

}
