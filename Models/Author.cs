namespace Moldovan_Alex_Lab2.Models
{
    public class Author
    {
        public int ID { get; set; }  // Cheia primară

        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        // Navigation property pentru Books (un autor poate avea mai multe cărți)
        public ICollection<Book> Books { get; set; }
    }

}
