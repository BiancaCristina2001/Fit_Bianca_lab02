using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Fit_Bianca_lab02.Models;

namespace Fit_Bianca_lab02.Data
{
    public class Fit_Bianca_lab02Context : DbContext
    {
        public Fit_Bianca_lab02Context (DbContextOptions<Fit_Bianca_lab02Context> options)
            : base(options)
        {
        }

        public DbSet<Fit_Bianca_lab02.Models.Book> Book { get; set; } = default!;

        public DbSet<Fit_Bianca_lab02.Models.Publisher> Publisher { get; set; }

        public DbSet<Fit_Bianca_lab02.Models.Author> Author { get; set; }
    }
}
