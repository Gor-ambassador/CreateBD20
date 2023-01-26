using Microsoft.EntityFrameworkCore;

namespace CreateDB20.DBStructure
{
    public class DataContext : DbContext
    {
        public DbSet<Info> Info { get; set; }//property

        public string DbPath { get; }

        public DataContext()
        {
            DbPath = "D:\\CreateDB20\\DataBase.db";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={DbPath}");
        }
    }
}
