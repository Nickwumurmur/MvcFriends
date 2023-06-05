using Microsoft.EntityFrameworkCore;
using MvcFriends.Models;
namespace MvcFriends.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }
        public DbSet<Friend> Friends { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Friend>().HasData(new Friend{ Id=1,Name="Nick1" , Email="nick@gmail.com",Mobile="0911-111111"},
            new Friend{Id=2,Name="Nick2" , Email="nick2@gmail.com",Mobile="0911-211111"},
            new Friend{Id=3,Name="Nick3" , Email="nick2@gmail.com",Mobile="0911-311111"});
        }
    }

}