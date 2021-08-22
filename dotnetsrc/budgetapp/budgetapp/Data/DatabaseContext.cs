using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using BudgetApp.Models;

namespace BudgetApp.Data
{
    public class DatabaseContext : DbContext
    {
        public static ILoggerFactory MyLoggerFactory;

        private static DbContextOptions<DatabaseContext> GetDbContextOptionsFromConnectionString(string connectionString)
        {
            var dbContextOptionsBuilder = new DbContextOptionsBuilder<DatabaseContext>();
            dbContextOptionsBuilder.UseSqlServer(connectionString);
            return dbContextOptionsBuilder.Options;
        }

        public DatabaseContext(string connectionString, ILoggerProvider loggerProvider)
            : this(GetDbContextOptionsFromConnectionString(connectionString), loggerProvider)
        {
        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options, ILoggerProvider loggerProvider)
            : base(options)
        {
            if (MyLoggerFactory == null && loggerProvider != null)
            {
                MyLoggerFactory = LoggerFactory.Create(builder => { builder.AddProvider(loggerProvider); });
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLoggerFactory(MyLoggerFactory)
                .EnableDetailedErrors()
                .EnableSensitiveDataLogging();
        }

        public DbSet<Expense> Expenses { get; set; }
    }
}
