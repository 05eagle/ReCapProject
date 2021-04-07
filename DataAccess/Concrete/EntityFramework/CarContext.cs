using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class CarContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=CarDb;Trusted_Connection=True");
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brands { get; set; }

        public DbSet<Color> Colors { get; set; }

        public DbSet<Rental> Rentals { get; set; }

        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<CarImage> CarImages { get; set; }




        //veritabanındaki sütun isimleriyle farklılık olduğunda yapılacak işlemler
        //fluet mapping
        //    protected override void OnModelCreating(ModelBuilder modelBuilder)
        //    {
        //        modelBuilder.Entity<SınıfIsmi>().ToTable(VeritabanındakiSütünİsmi);//sınıf ismimizle veritabanındaki hangi sütünü bağlayacağımızı belirtiyoruz.
        //        modelBuilder.Entity<SınıfınIsmi>().Property(p=>p.Sütunİsmi).HasColumnName(VerirtabanındakiSütünİsmi)
        //    }
    }
}
