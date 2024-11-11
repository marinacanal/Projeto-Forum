using Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    // aqui eu implemento os metodos estabelecidos na minha interface
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbContext _context; // gerencia conexao com o banco
        private readonly DbSet<T> _dbSet; // manipula operacoes na tabela

        public Repository(DbContext context){
            _context = context;
            _dbSet = _context.Set<T>();
        }
        
        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _dbSet.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            _dbSet.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}