using System.ComponentModel.DataAnnotations;

namespace UniversityBackend.Models.DataModels
{
    public class BaseEntity
    {

        [Required]
        [Key]
        public int Id { get; set; }
        public string CreateBy { get; set; } = string.Empty;
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public string UpdateBy { get; set; }= string.Empty;
        public string DeleteBy { get; set; } = string.Empty;
        public bool IsDeleted { get; set; }

    }
}
