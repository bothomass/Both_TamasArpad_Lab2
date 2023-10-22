using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Both_TamasArpad_Lab2.Models;

namespace Both_TamasArpad_Lab2.Data
{
    public class Both_TamasArpad_Lab2Context : DbContext
    {
        public Both_TamasArpad_Lab2Context (DbContextOptions<Both_TamasArpad_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Both_TamasArpad_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Both_TamasArpad_Lab2.Models.Publisher>? Publisher { get; set; }
    }
}
