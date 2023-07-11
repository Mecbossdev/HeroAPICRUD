using System;
using HeroiApi.Models;
using Microsoft.EntityFrameworkCore;

namespace HeroiApi.Data
{
	public class HeroiDbContext : DbContext
	{
		public DbSet<Heroi> Herois { get; set; }

		public DbSet<Armas> Armas { get; set; }

		public DbSet<Batalhas> Batalhas { get; set; }

		public HeroiDbContext(DbContextOptions options) : base(options)
		{

		}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}

