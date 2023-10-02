using System.Security.Cryptography.X509Certificates;


[ApiController]
[Route("api/[controller]")]


public class BooksController : Controller
{
    //define a global variable _context
    private readonly BooksDb _context;

    //constructor
    public BooksController(BooksDb context)
    {
        _context = context;
    }

    //GET: api/books
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Book>>> GetBooks()
    {
        return await _context.Books.ToListAsync();
    }

    //GET api/books/id
    [HttpGet("{id}")]
    public async Task<ActionResult<Book>> GetBook(int id)
    {
        var book = await _context.Books.FindAsync(id);

        if(book == null)
            return NotFound();

        return book;
    }

    //POST api/books
    [HttpPost]
    public async Task<ActionResult<Book>>  PostBook(Book book)
    {
        _context.Books.Add(book);
        await _context.SaveChangesAsync();
        return CreatedAction("GetBook", new {id = book.Id},book);
    }

    //PUT api/books/id
    [HttpPut("{id}")]
    public sync Task<IActionResult> PutBook(int id, Book book)
    {
        if(id != book.Id)
            return BadRequest();

        var bookInDb = await _context.Books.FindAsync(id);

        if(bookInDb == null)
            return NotFound();

        _context.Entry(book).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return NoContent();
    }

    //DELETE api/books/id
    [HttpDelete("{id}")]
    public async Task<ActionResult<Book>> DeleteBook(int id)
    {
        var book = await _context.Books.FindAsync(id);

        if(book == null)
            return NotFound();

        _context.Books.Remove(book);
        await _context.SaveChangesAsync();

        return book;
    }
}