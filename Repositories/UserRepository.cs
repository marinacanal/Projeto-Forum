using barbieProject.Models;
using Microsoft.EntityFrameworkCore;

namespace barbieProject.Repositories
{
    public class UserRepository : Repository<User>
    {
        private readonly DbContext _context;
        private readonly DbSet<User> _dbSet;
        public UserRepository(DbContext context) : base(context)
        {
            _context = context;
            _dbSet = _context.Set<User>();
        }

        public async Task<User> GetUserByNameAsync(string username) {
            return await _dbSet.FirstOrDefaultAsync(user => user.UserName == username);
        }
    }
}