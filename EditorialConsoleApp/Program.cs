// See https://aka.ms/new-console-template for more information
using EditorialData.Core.Framework;
using EditorialDomain.Models;

using (DataContext context = new DataContext())
{
    context.Database.EnsureCreated();
}

//GetAuthors();
//AddAuthor();
//GetAuthors();
GetAuthorsWhithBooks();
//AddAuthorWithBoook();
//GetAuthorsWhithBooks();


void GetAuthors()
{
    using DataContext context = new DataContext();

         List<Author> authors = context.Authors.ToList();
         foreach (Author author in authors)
         {
             Console.WriteLine(author.Name + " " + author.LastName);
         }
}

void AddAuthor()
{
    Author author = new Author() { Name = "Juan", LastName = "Bosh" , IsActive = true };

    using DataContext context = new DataContext();

    context.Add(author);
    context.SaveChanges();
}

void AddAuthorWithBoook()
{
    Author author =  new Author { Name = "Joanne ", LastName ="Rowling", IsActive = true };
    author.Books.Add(new Book
    {
        Title = "Hary Potter and the Philosopher stone",
        PublishDate = new DateTime (1997,1 ,1),
        BasePrice = (decimal)30.00,
        Gender = EditorialDomain.Enums.Gender.Mythology
    });
    author.Books.Add(new Book
    {
        Title = "Harry Potter and the Chamber of Secrets",
        PublishDate = new DateTime(1998,6,2),
        BasePrice = (decimal)35.00,
        Gender = EditorialDomain.Enums.Gender.Mythology
    });

    using DataContext context = new DataContext();

    context.Add(author);
    context.SaveChanges();
}

void GetAuthorsWhithBooks()
{
    using DataContext context = new DataContext();

    List<Author> authors = context.Authors
                            .Where( x => x.Id == 3)
                            .Select(x => new Author
                            {
                                Id = x.Id,
                                Name = x.Name,
                                LastName = x.LastName,
                                Books = x.Books
                                .Select(b => new Book
                                {
                                        Id = b.Id,
                                        Title = b.Title,
                                        Gender = b.Gender,
                                        BasePrice = b.BasePrice,
                                        PublishDate= b.PublishDate,
                                    }).ToList()
                            }).ToList();
    foreach (Author author in authors)
    {
        Console.WriteLine(author.Name + " " + author.LastName);
        Console.WriteLine("-----------------------------------Libros Publicados------------------------------------------");
        foreach (Book book in author.Books)
        {
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine("*" + book.Title + ", " + book.Gender.ToString() + ", " + book.PublishDate );
        }
    }

}