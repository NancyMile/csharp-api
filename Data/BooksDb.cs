using Microsoft.EntityFrameworkCore;

// namespace firstAPI.Data
// {
    public class BooksDb : DbContext
    {
        //construct
        public BooksDb(DbContextOptions<BooksDb> options) : base(options)
        {

        }

        //define table Books
        public DbSet<Book> Books => Set<Book>();
    }
//}