using InternetBankingSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace InternetBankingSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<User> Users { get; set; }

        public DbSet<Account> Accounts { get; set; }

        public DbSet<Transaction> Transactions { get; set; }

        public DbSet<Announcement> Announcements { get; set; }
    }
}