using Microsoft.EntityFrameworkCore;
using TelegramBot.Model.DataBaseModels;

namespace TelegramBot.Model
{
    public class ApplicationContext: DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=TelegramBotDb;Trusted_Connection=True;");
        }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
