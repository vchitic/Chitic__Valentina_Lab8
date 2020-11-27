using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Chitic__Valentina_Lab8.Models;

namespace Chitic__Valentina_Lab8.Data
{
    public class Chitic__Valentina_Lab8Context : DbContext
    {
        public Chitic__Valentina_Lab8Context (DbContextOptions<Chitic__Valentina_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Chitic__Valentina_Lab8.Models.Book> Book { get; set; }

        public DbSet<Chitic__Valentina_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Chitic__Valentina_Lab8.Models.Category> Category { get; set; }

        public DbSet<Chitic__Valentina_Lab8.Models.BookCategory> BookCategory { get; set; }
    }
}
