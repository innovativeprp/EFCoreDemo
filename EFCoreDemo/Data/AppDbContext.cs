using EFCoreDemo.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace EFCoreDemo.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Membership> Memberships { get; set; }
        public DbSet<PersonalLibrary> PersonalLibraries { get; set; }
        //Restricting max length by fluent Api
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          //  modelBuilder.Entity<Author>().HasKey(b => new { b.FirstName, b.LastName });//Composite Primary Key
            modelBuilder.Entity<Book>().Property(b => b.Isbn).HasMaxLength(10);
            // modelBuilder.Entity<Book>().HasAlternateKey(b => b.Isbn).HasName("UniqueIsbn");

            //By using Index we ned to explicitly make it unique 
            modelBuilder.Entity<Book>().HasIndex(b => b.Isbn).HasName("UniqueIsbn").IsUnique();

            modelBuilder.Entity<Book>().Ignore(b => b.TestProperty);

            //Shadow Properties: These properties are not visible in the model class.
            modelBuilder.Entity<Book>().Property<DateTime>("CreatedAt").HasDefaultValueSql("getdate()");

            
        }
    }
}
