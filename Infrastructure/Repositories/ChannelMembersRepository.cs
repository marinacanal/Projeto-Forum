
using Forum.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class ChannelUserRepository : Repository<ChannelMembers>
    {
        private readonly DbContext _context;
        private readonly DbSet<ChannelMembers> _dbSet;
        public ChannelUserRepository(DbContext context) : base(context)
        {
            _context = context;
            _dbSet = _context.Set<ChannelMembers>(); 
        }

        public async Task<List<User>> GetUsersInChannelAsync(int channelId) {
            return await _dbSet
                .Where(channelMembers => channelMembers.ChannelId == channelId)
                .Select(channelMembers => channelMembers.User)
                .ToListAsync();
        }
    }
}