using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface ICourseService
    {
        IList<Course> GetCourses();
        Course GetCourseByCourseId(long courseId);
        Course InsertCourse(Course course);
        bool UpdateCourse(Course course);
        bool DeleteCourse(int courseId);
    }
}
