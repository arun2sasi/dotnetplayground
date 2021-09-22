using Domain.Entities;
using Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace online_learning_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoursesController : ControllerBase
    {
        private readonly ICourseService _courseService;
        public CoursesController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        /// <summary>
        /// Returns all courses.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetCourses()
        {
            return Ok(_courseService.GetCourses());
        }

        [HttpGet("{courseId:int}")]
        public IActionResult GetCourseById(int courseId)
        {
            return Ok(_courseService.GetCourseByCourseId(courseId));
        }

        [HttpPost]
        public IActionResult AddCourse([FromBody] Course course)
        {
            return Created("", new { Created = _courseService.InsertCourse(course) });
        }

        [HttpPut]
        public IActionResult UpdateCourse([FromBody] Course course)
        {
            var isSuccess = _courseService.UpdateCourse(course);
            if (isSuccess)
            {
                return Ok(_courseService.GetCourseByCourseId(course.CourseId));
            }
            else
            {
                return NoContent();
            }
        }

        [HttpDelete("{courseId}")]
        public IActionResult DeleteCourse(int courseId)
        {
            var isSuccess = _courseService.DeleteCourse(courseId);
            if (isSuccess)
            {
                return Ok();
            }
            else
            {
                return NoContent();
            }
        }
    }
}
