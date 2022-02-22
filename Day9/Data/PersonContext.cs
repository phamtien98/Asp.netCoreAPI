using Microsoft.EntityFrameworkCore;
using Day9.Model;
namespace Day9.Data
{
    public class PersonContext : DbContext
    {

        public PersonContext(DbContextOptions<PersonContext> options)
          : base(options) { }
        public DbSet<Person> person { get; set; }

    }
}