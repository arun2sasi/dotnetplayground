using Domain.Entities;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services
{
    public class CourseService : ICourseService
    {
        private readonly IDataStore _dataStore;
        public CourseService(IDataStore dataStore)
        {
            _dataStore = dataStore;
        }
        public Course GetCourseByCourseId(long courseId)
        {
            return GetCourses().Where(c => c.CourseId == courseId).First();
        }

        public IList<Course> GetCourses()
        {
            var courses = _dataStore.All<Course>();
            return courses.ToList();
        }

        public Course InsertCourse(Course course)
        {
            var courseId = _dataStore.Insert<Course>(course);
            var result = GetCourseByCourseId(courseId);
            return result;
        }

        public bool UpdateCourse(Course course)
        {
            return _dataStore.Update<Course>(course);
        }

        public bool DeleteCourse(int courseId)
        {
            var course = GetCourseByCourseId(courseId);
            if (course != null)
            {
                return _dataStore.Delete<Course>(course);
            }
            else
            {
                return false;
            }
        }
    }
}
