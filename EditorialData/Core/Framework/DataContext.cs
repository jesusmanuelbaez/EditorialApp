using EditorialDomain.Models;
using Microsoft.EntityFrameworkCore;

namespace EditorialData.Core.Framework
{
    public class DataContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Programacion\\source\\repos\\EditorialApp\\EditorialData\\Core\\Data\\EditorialDb.mdf;Integrated Security=True");
        }
    }
}
