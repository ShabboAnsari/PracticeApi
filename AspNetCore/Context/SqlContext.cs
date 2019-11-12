using Microsoft.EntityFrameworkCore;
using PracticeApi.Models;

namespace PracticeApi.Context
{
    public class SqlContext : DbContext
    {
        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        {

        }

        public DbSet<User> User { get; set; }
        public DbSet<Contacts> Contacts { get; set; }
        public DbSet<Pages> Pages { get; set; }
        public DbSet<Blogs> Blogs { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Products> Products { get; set; }

    }
}