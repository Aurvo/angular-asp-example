using Dotnetng.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Dotnetng.API.Data {
    public class DataContext : DbContext {

        public DbSet<Value> values { get; set; }

        public DataContext(DbContextOptions<DataContext> optinos) : base(optinos) {}
        
    }
}