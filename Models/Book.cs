using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace Moldovan_Alex_Lab2.Models
{
    public class Book
    {
        public int ID { get; set; }

        [Display(Name = "Book Title")]
        public string Title { get; set; }

        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }

        [DataType(DataType.Date)]
        public DateTime PublishingDate { get; set; }

        // Cheie străină către entitatea Author
        public int? AuthorID { get; set; }
        public Author? Author { get; set; }  // Navigation property

        public int? PublisherID { get; set; }
        public Publisher? Publisher { get; set; }  // Navigation property
        public ICollection<BookCategory> BookCategories { get; set; } = new List<BookCategory>();
        public ICollection<Borrowing>? Borrowings { get; set; }


    }
}
