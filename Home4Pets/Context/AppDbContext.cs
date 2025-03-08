using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Home4Pets.Models;
using Microsoft.EntityFrameworkCore;

namespace Home4Pets.Context
{
    public class AppDbContext : DbContext
    {

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<AdoptionRequest>()
                .HasOne(ar => ar.User)
                .WithMany(u => u.AdoptionRequests)
                .HasForeignKey(ar => ar.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<AdoptionRequest>()
                .HasOne(ar => ar.Pet)
                .WithMany(p => p.AdoptionRequests)
                .HasForeignKey(ar => ar.PetId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Pet>()
                .HasOne(p => p.User)
                .WithMany(u => u.Pets)
                .HasForeignKey(p => p.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Adoption>()
                .HasOne(a => a.User)
                .WithMany()
                .HasForeignKey(a => a.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Adoption>()
                .HasOne(a => a.Pet)
                .WithMany()
                .HasForeignKey(a => a.PetId)
                .OnDelete(DeleteBehavior.NoAction);


            modelBuilder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();

            base.OnModelCreating(modelBuilder);

        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("");

            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<PetType> PetTypes { get; set; }
        public DbSet<AdoptionRequest> AdoptionRequests { get; set; }
        public DbSet<Adoption> Adoptions { get; set; }
    }
}
