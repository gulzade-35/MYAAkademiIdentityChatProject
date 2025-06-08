using IdentityChatProject.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityChatProject.Context
{
    public class MailContext : IdentityDbContext<AppUser>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ACER_VN7\\SQLEXPRESS; initial Catalog=EmailChatProjectDb;integrated Security=true");

        }

        public DbSet<Message> Messages { get; set; }
    }
}
