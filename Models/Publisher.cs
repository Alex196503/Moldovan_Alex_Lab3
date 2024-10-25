using System.ComponentModel.DataAnnotations;

namespace Moldovan_Alex_Lab2.Models
{
    public class Publisher
    {
        public int ID { get; set; }
        [Required]
        [StringLength(100)]
        public string? PublisherName { get; set; }
        public ICollection<Book>? Books { get; set; }
    }
}
