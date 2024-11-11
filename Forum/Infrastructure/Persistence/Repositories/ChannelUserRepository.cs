using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Models.Channel;
using Domain.Models.User;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class ChannelUserRepository : Repository<ChannelUser>
    {
        private readonly DbContext _context;
        private readonly DbSet<ChannelUser> _dbSet;
        public ChannelUserRepository(DbContext context) : base(context)
        {
            _context = context;
            _dbSet = _context.Set<ChannelUser>(); 
        }

        public async Task<List<User>> GetUsersInChannelAsync(int channelId) {
            return await _dbSet
                .Where(channelUser => channelUser.ChannelId == channelId)
                .Select(channelUser => channelUser.User)
                .ToListAsync();
        }
    }
}