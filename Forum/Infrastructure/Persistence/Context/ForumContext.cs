using Domain.Models.Channel;
using Domain.Models.User;
using Forum.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Context
{
    public class ForumContext : DbContext
    {
        public ForumContext(DbContextOptions<ForumContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Channel> Channels { get; set; }
        public DbSet<ChannelUser> ChannelUser { get; set; }
    }
}