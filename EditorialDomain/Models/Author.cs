namespace EditorialDomain.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public List<Book> Books { get; set; }
        public bool IsActive { get; set; }

        public Author()
        {
            Books = new List<Book>();
        }
    }
}