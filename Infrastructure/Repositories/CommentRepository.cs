using Forum.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class CommentRepository : Repository<Comment>
    {
        private readonly DbContext _context;
        private readonly DbSet<Comment> _dbSet;
        public CommentRepository(DbContext context) : base(context)
        {
            _context = context;
            _dbSet = _context.Set<Comment>();
        }

        public async Task<List<Comment>> GetByPostIdAsync(int postId) {
            return await _dbSet
                .Where(comment => comment.PostId == postId)
                .ToListAsync();
        }

        public async Task<List<Comment>> GetContainsContentAsync(string content) {
            return await _dbSet
                .Where(comment => comment.Content.Contains(content))
                .ToListAsync();
        }
    }
}