using Microsoft.Build.Framework;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace UniversityBackend.Models.DataModels
{
    public class Student : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public DateTime DOB { get; set; }
        
        public ICollection<Course> Courses { get; set; } = new List<Course>();
        [Required]
        public ICollection<Student> Students { get; set; } = new List<Student>();

    }
}
