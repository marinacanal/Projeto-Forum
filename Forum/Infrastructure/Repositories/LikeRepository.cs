using Forum.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class LikeRepository : Repository<Like>
    {
        private readonly DbContext _context;
        private readonly DbSet<Like> _dbSet;
        public LikeRepository(DbContext context) : base(context)
        {
            _context = context;
            _dbSet = context.Set<Like>();
        }

        public async Task<List<Like>> GetByPostIdAsync(int postId) {
            return await _dbSet
                .Where(like => like.PostId == postId)
                .ToListAsync();
        }
    }
}