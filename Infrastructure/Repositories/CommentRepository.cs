using Domain.Forum.Entities;
using Domain.Forum.Repositories;
using Domain.Forum.ValueObjects;
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

        // get all
        public async Task<List<Comment>> GetAllByPostIdAsync(Guid postId) {
            return await _dbSet
                .Where(comment => comment.PostId == postId)
                .ToListAsync();
        }

        public async Task<List<Comment>> GetAllByUserIdAsync(Guid userId)
        {
            return await _dbSet
                .Where(comment => comment.UserId == userId)
                .ToListAsync();
        }

        // get contains
        public async Task<List<Comment>> GetContainsContentAsync(CommentContent content) {
            return await _dbSet
                .Where(comment => comment.Content.Value.Contains(content.ToString()))
                .ToListAsync();
        }

        // create
        public async Task CreateAsync(Comment comment)
        {
            await _dbSet.AddAsync(comment);
            await _context.SaveChangesAsync();
        }

        // update
        public async Task UpdateAsync(Comment comment)
        {
            _dbSet.Update(comment);
            await _context.SaveChangesAsync();
        }

        // delete
        public async Task DeleteAsync(Comment comment)
        {
            _dbSet.Remove(comment);
            await _context.SaveChangesAsync();
        }
    }
}