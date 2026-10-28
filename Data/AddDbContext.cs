using Microsoft.EntityFrameworkCore;
using System.Threading.RateLimiting;
using WebApplication4.Models.Commons;

namespace WebApplication4.Data
{
    public class AddDbContext(DbContextOptions<AddDbContext>options):DbContext(options)
    {
        public DbSet<Slider> Sliders { get; set; }
    }
}
