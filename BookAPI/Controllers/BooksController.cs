using BookAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookAPI.Controllers
{
    [Route("api/[Controller]")] //https://localhost:7152/api/books
    [ApiController]
    public class BooksController : ControllerBase
    {
        private Book[] _books = new Book[]
            { 
                new Book { Id = 1, Author = "J.H.J Terstegge", Title = "Grip op de AVG" },
                new Book { Id = 2, Author = "Hans Baars, Jule Hintzbergen, Kees Hintzbergen", Title = "Basiskennis informatiebeveiliging" },
                new Book { Id = 3, Author = "Roel Grit", Title = "Informatiemanagement" },
                new Book { Id = 4, Author = "Jos Warmer, Anneke Kleppe", Title = "Praktisch UML" }
            };

        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetBooks()
        {
            return Ok(_books);
        }
    }
}
