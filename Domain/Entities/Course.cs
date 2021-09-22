using Dapper.Contrib.Extensions;

namespace Domain.Entities
{
    [Table("Course")]
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }

    }
}
