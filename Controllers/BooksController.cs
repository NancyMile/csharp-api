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

    }

    //GET api/books/id
    [HttpGet("{id}")]
    public async Task<ActionResult<Book>> GetBook(int id)
    {

    }

    //POST api/books
    [HttpPost]
    public async Task<ActionResult<Book>>  PostBook(Book book)
    {

    }

    //PUT api/books/id
    [HttpPut("{id}")]
    public sync Task<IActionResult> PutBook(int id, Book book)
    {

    }

    //DELETE api/books/id
    [HttpDelete("{id}")]
    public async Task<ActionResult<Book>> DeleteBook(int id)
    {

    }
}