using Domain.Models.User;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    // aqui eu herdo todos os metodos estabelecidos na minha classe Repository
    public class UserRepository : Repository<User>
    {
        private readonly DbContext _context; // readonly signifca que eu so posso atribuir o valor da variavel uma vez
        private readonly DbSet<User> _dbSet;
        public UserRepository(DbContext context) : base(context)
        {
            _context = context;
            _dbSet = _context.Set<User>();
        }

        public async Task<User> GetByEmailAsync(string email) {
            return await _dbSet.FirstOrDefaultAsync(user => user.Email == email);
        }

        public async Task<User> GetByUserNameAsync(string username) {
            return await _dbSet.FirstOrDefaultAsync(user => user.UserName == username);
        }

        public async Task<List<User>> GetContainsUserNameAsync(string username) {
            return await _dbSet
                .Where(user => user.UserName.Contains(username))
                .ToListAsync();
        }
    }
}