using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Florea_Iulia_Lab8.Models;

namespace Florea_Iulia_Lab8.Data
{
    public class Florea_Iulia_Lab8Context : DbContext
    {
        public Florea_Iulia_Lab8Context (DbContextOptions<Florea_Iulia_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Florea_Iulia_Lab8.Models.Book> Book { get; set; }

        public DbSet<Florea_Iulia_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Florea_Iulia_Lab8.Models.Category> Category { get; set; }
    }
}
