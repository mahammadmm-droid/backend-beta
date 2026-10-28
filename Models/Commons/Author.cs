using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models.Commons
{
    public class Author : BaseEntity
    {
       
        public string Name { get; set; } = null!;
        public List<Book>? Books { get; set; }
    }
}
