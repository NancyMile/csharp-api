
public class BooksDb : DbContext
{
    //construct
    public BookDb(DbContextOptions<BooksDb> options) : base(options)
    {

    }

    //define table Books
    public DbSet<Book> Books => Set<Book>();
}