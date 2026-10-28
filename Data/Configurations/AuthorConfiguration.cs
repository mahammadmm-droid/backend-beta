using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication4.Models.Commons;

namespace WebApplication4.Data.Configurations
{
    public class AuthorConfiguration: IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.Property(a => a.Name).IsRequired().HasMaxLength(20);
        }
    }
}
