using Forum.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class PostRepository : Repository<Post>
    {   
        private readonly DbContext _context;
        private readonly DbSet<Post> _dbSet;
        public PostRepository(DbContext context) : base(context)
        {
            _context = context;
            _dbSet = _context.Set<Post>();
        }

        public async Task<List<Post>> GetByUserIdAsync(int userId) {
            return await _dbSet
                .Where(post => post.UserId == userId)
                .ToListAsync();
        }

        public async Task<List<Post>> GetContainsContentAsync(string content) {
            return await _dbSet
                .Where(post => post.Content.Contains(content))
                .ToListAsync();
        }

        public async Task<List<Post>> GetContainsTitleAsync(string title) {
            return await _dbSet
                .Where(post => post.Title.Contains(title))
                .ToListAsync();
        }

        public async Task<List<Post>> GetInChannelAsync(int channelId) {
            return await _dbSet
                .Where(post => post.ChannelId == channelId)
                .ToListAsync();
        }
    }
}