﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebAppForumDemo.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Sciv.Models
{
    public class ScivDbContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Topic> Topics { get; set; }

        public ScivDbContext(DbContextOptions options) : base(options)
        {

        }

		public DbSet<IdentityUserClaim<int>> IdentityUserClaim { get; set; }

        public DbSet<IdentityUserRole<int>> IdentityUserRole { get; set; }

        public DbSet<IdentityRole<int>> IdentityRole { get; set; }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityUserRole<int>>(
                eb =>
                {
                    eb.HasNoKey();
                });
        }
    }
}