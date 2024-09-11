namespace barbieProject.Repositories
{
    public interface IRepository<T> where T : class
    {
        Task<T> GetByIdAsync(int id); // tarefa assincrona, nao da block no banco
        Task<IEnumerable<T>> GetAllAsync();
        Task AddAsync(T entity);
        void Update(T entity); // tarefa sincrona, void pois nao tem retorno
        void Delete(T entity);
    }
}