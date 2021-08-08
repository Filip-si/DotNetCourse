
using DotNetCourse.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNetCourse.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

            
        }
        public DbSet<Item> Items { get; set; }  
        
        public DbSet<Character> Characters { get; set; }
        public DbSet<User> Users { get; set; }


        
        
    }
}