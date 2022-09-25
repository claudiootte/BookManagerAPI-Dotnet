using Microsoft.EntityFrameworkCore;

using RestAPI_CSharp.src.Models;


namespace RestAPI_CSharp.src.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        { }


        public DbSet<Book> Books => Set<Book>();

    }
}
