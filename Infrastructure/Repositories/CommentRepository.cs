using Domain.Forum.Entities;
using Domain.Forum.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class CommentRepository : ICommentRepository
    {
        private readonly DbContext _context;
        private readonly DbSet<Comment> _dbSet;
        public CommentRepository(DbContext context)
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