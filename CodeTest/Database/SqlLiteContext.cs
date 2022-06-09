using CodeTest.Data;
using Microsoft.EntityFrameworkCore;

namespace CodeTest.Database
{
    public class SqlLiteContext : DbContext
    {
        public DbSet<PersonEntity> People { get; set; }

        public SqlLiteContext()
        {
            this.Database.OpenConnection();
            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
            => builder.UseSqlite("DataSource=file::memory:?cache=shared");

        public void Dispose()
        {
            this.Database.CloseConnection();
            base.Dispose();
        }
    }
}
