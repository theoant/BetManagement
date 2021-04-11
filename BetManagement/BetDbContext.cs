using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BetManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace BetManagement
{
    public class BetDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(@"Server=localhost;Database=BetDb; Trusted_Connection = True; ConnectRetryCount = 0;");
        }

        public DbSet<Match> Match { get; set; }
        public DbSet<MatchOdds> MatchOdds { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Match>().HasKey(c =>  c.ID );
            modelBuilder.Entity<MatchOdds>().HasKey(p => new { p.ID, p.MatchId });       
        }
    }
}
