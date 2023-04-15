using System;

namespace BookStoreAPI.Entity
{
    public class Book
    {
        public int ID { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public int GenreID { get; set; }

        public int PageCount;

        public DateTime PublishDate { get; set; }
    }
}
