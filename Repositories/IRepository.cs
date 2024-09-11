using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace barbieProject.Repositories
{
    public interface IRepository<T> where T : class
    {
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task AddAsync(T entity);
        void Update();
        void Delete();
    }
}