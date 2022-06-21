using EditorialDomain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorialDomain.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime PublishDate { get; set; }
        public decimal BasePrice { get; set; }
        public Author Author { get; set; }
        public int AuthorId { get; set; }
        public Gender Gender { get; set; }
        public  bool IsPublished { get; set; }
    }
}
