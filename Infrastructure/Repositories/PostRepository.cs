using Forum.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class PostRepository : IPostRepository
    {   
        private readonly DbContext _context;
        private readonly DbSet<Post> _dbSet;
        public PostRepository(DbContext context) 
        {
            _context = context;
            _dbSet = _context.Set<Post>();
        }

        // get by
        public async Task<Post> GetByIdAsync(Guid id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<List<Post>> GetByUserIdAsync(Guid userId) {
            return await _dbSet
                .Where(post => post.UserId == userId)
                .ToListAsync();
        }

        // get contains
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

        // get in
        public async Task<List<Post>> GetInChannelAsync(Guid channelId) {
            return await _dbSet
                .Where(post => post.ChannelId == channelId)
                .ToListAsync();
        }

        // get all
        public async Task<List<Post>> GetAllAsync() {
            return await _dbSet.ToListAsync();
        }

        // create
        public async Task CreateAsync(Post post) {
            await _dbSet.AddAsync(post);
            await _context.SaveChangesAsync();   
        }

        // update
        public async Task UpdateAsync(Post post) {
            _dbSet.Update(post);
            await _context.SaveChangesAsync();
        }

        // delete
        public async Task DeleteAsync(Post post) {
            _dbSet.Remove(post);
            await _context.SaveChangesAsync();
        }
    }
}