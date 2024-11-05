using Microsoft.EntityFrameworkCore;
using WPFTestTask.Repository.TestData;


namespace WPFTestTask.Repository
{
    public class ApplicationContext : DbContext
    {
        public DbSet<TestEntity> TestEntities => Set<TestEntity>();
        public ApplicationContext() => Database.EnsureCreated();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=wpf_test_task.db");
        }
    }
}
