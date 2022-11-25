using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace UniversityBackend.Models.DataModels
{
    public enum Level
    {
        Basic,
        Medium,
        Advance,
        Expert
    }

    public class Course:BaseEntity
    {
        [Required, StringLength(50)]
        public string Name { get; set; }=string.Empty;
        [Required]
        public string Description { get; set; } = string.Empty;
        [Required, StringLength(280)]
        public string ShortDescription { get; set; } = string.Empty;
        [Required]
        public Level Level { get; set; } = Level.Basic;

        [Required]
        public ICollection<Category> Categories { get; set; }=new List<Category>();

        [Required]
        public Chapter Chapters { get; set; } = new Chapter();

    }
}
