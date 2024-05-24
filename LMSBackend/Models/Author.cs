using System.ComponentModel.DataAnnotations;

namespace LMSBackend.Models
{
    public class Author
    {
        [Key]
        public int AuthId { get; set; }
        public string? AuthName { get; set; }

        public required ICollection<Books> Books { get; set; }
    }
}
