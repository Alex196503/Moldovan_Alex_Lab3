using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Moldovan_Alex_Lab2.Models;

namespace Moldovan_Alex_Lab2.Data
{
    public class Moldovan_Alex_Lab2Context : DbContext
    {
        public Moldovan_Alex_Lab2Context (DbContextOptions<Moldovan_Alex_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Moldovan_Alex_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Moldovan_Alex_Lab2.Models.Publisher> Publisher { get; set; }
        public DbSet<Author> Authors { get; set; } // Adaugă noua entitate Authors

    }
}
