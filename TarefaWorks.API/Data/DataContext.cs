using Microsoft.EntityFrameworkCore;
using TarefaWorks.API.Models;

namespace TarefaWorks.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Card> Cards { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
