using Microsoft.EntityFrameworkCore;
using ChatMVCCore.Models;

namespace ChatMVCCore.Data
{
    public class MessageContext : DbContext
    {
        public MessageContext (DbContextOptions<MessageContext> options) : base(options) { }

        public DbSet<MessageModel> Messages { get; set; }   
    }
}
