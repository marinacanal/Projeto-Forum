using barbieProject.Models;
using Microsoft.EntityFrameworkCore;

namespace barbieProject.Repositories
{
    public class ChannelRepository : Repository<Channel>
    {
        private readonly DbContext _context;
        private readonly DbSet<Channel> _dbSet;
        public ChannelRepository(DbContext context) : base(context)
        {
            _context = context;
            _dbSet = _context.Set<Channel>(); 
        }

        public async Task<List<Channel>> GetContainsNameAsync(string name) {
            return await _dbSet
                .Where(channel => channel.Name.Contains(name))
                .ToListAsync();
        }
    }
}