using System.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStoreAPI.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BookStoreAPI.AddControllers
{
    [ApiController]
    [Route("[controller]s")]
    public class BookController : ControllerBase
    {
        private static List<Book> BookList = new List<Book>()
        {
            new Book
            {
                ID = 1,
                Title = "Sefiller",
                Author = "Victor Hugo",
                GenreID = 1, // Felsefe
                PageCount = 215,
                PublishDate = new DateTime(2016, 01, 1)
            },
            new Book
            {
                ID = 2,
                Title = "Bir İdam Mahkumunun Son Günü",
                Author = "Victor Hugo",
                GenreID = 1, // Felsefe
                PageCount = 76,
                PublishDate = new DateTime(2013, 01, 1)
            },
            new Book
            {
                ID = 3,
                Title = "Dune",
                Author = "Frank Herbert",
                GenreID = 2, // Bilim Kurgu
                PageCount = 696,
                PublishDate = new DateTime(1965, 08, 1)
            }
        };

        [HttpGet]
        public List<Book> GetBooks()
        {
            return BookList; 
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var book = BookList.FirstOrDefault(x => x.ID == id);
            if (book == null)
            {
                return NotFound();
            }
            return Ok(book);
        }
        [HttpPost]
        public IActionResult BookAdd(Book book)
        {
            int ID = BookList.Max(b => b.ID) + 1;
            book.ID = ID;
            BookList.Add(book);

            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult BookDelete(int id)
        {
            var book = BookList.FirstOrDefault(x => x.ID == id);

            if (book == null)
            {
                return NotFound();
            }

            BookList.Remove(book);

            foreach (var remainingBook in BookList.Where(x => x.ID > id)) // ortadan sayı silindiğinde idleri tekrar düzenler
            {
                remainingBook.ID--;
            }
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult BookUpdate(int id, Book updatedBook)
        {
            var book = BookList.FirstOrDefault(x => x.ID == id);
            if (book == null)
            {
                return NotFound();
            }
            book.Title = updatedBook.Title;
            book.Author = updatedBook.Author;
            book.GenreID = updatedBook.GenreID;
            book.PageCount = updatedBook.PageCount;
            book.PublishDate = updatedBook.PublishDate;
            
            return Ok();
        }
    }
}