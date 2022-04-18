﻿using Microsoft.EntityFrameworkCore;

namespace BookStore.DataBase
{
    public class BookStoreContext : DbContext
    {
        public BookStoreContext(DbContextOptions<BookStoreContext> options)
            : base(options)
        {

        }
        public DbSet<Books> Books { get; set; }
        public DbSet<Language> Languages { get; set; }
    }
}
