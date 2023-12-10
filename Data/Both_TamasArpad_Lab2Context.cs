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

        public DbSet<Both_TamasArpad_Lab2.Models.Author>? Author { get; set; }

        public DbSet<Both_TamasArpad_Lab2.Models.Category>? Category { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Book>()
                .HasOne(b => b.Borrowing)
                .WithOne(b => b.Book)
                .HasForeignKey<Borrowing>(b => b.BookID);
        }

        public DbSet<Both_TamasArpad_Lab2.Models.Member>? Member { get; set; }

        public DbSet<Both_TamasArpad_Lab2.Models.Borrowing>? Borrowing { get; set; }
    }
}
