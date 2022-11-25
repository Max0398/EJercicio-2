using System.ComponentModel.DataAnnotations;

namespace UniversityBackend.Models.DataModels
{
    public class Chapter:BaseEntity
    {
        public int CourseId { get; set; }
        [Required]
        public string List=string.Empty;
        public virtual Course Courses { get; set; } =new Course();
    
    }
}
