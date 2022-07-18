using System.ComponentModel.DataAnnotations;

namespace UniversityAPIBack.Models.DataModel
{
    public class Course : BaseEntity
    {
        [Required, StringLength(50)]
        public string Name { get; set; } = string.Empty;

        [Required, StringLength(280)]
        public string ShortDescription { get; set; } = string.Empty;

        [Required]
        public string LongDescription { get; set; } = string.Empty;

        public string PublicObjetive { get; set; } = string.Empty;

        public string Objetives { get; set; } = string.Empty;

        public string Requirements { get; set; } = string.Empty;

        public Level Level { get; set; }

        [Required]
        public Chapter Chapters { get; set; } = new Chapter();

        [Required]
        public ICollection<Category> Categories { get; set; } = new List<Category>();

        [Required]
        public ICollection<Student> Students { get; set; } = new List<Student>();
    }

    public enum Level
    {

        Basic = 1,
        Intermediate = 2,
        Advanced = 3
    }
}
