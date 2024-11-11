namespace Forum.Models {
    public interface IUserRepository {

        // get by 
        Task<User> GetByIdAsync(int id); // tarefa assincrona, nao bloqueia threads
        Task<User> GetByEmailAsync(string useremail);
        Task<User> GetByUserNameAsync(string username);

        // get contains
        Task<User> GetContainsUserNameAsync(string username);

        // get all
        Task<IEnumerable<User>> GetAllAsync();

        // add
        Task AddAsync(User user);

        //update
        Task UpdateAsync(User user); 

        // delete
        Task DeleteAsync(User user);

        Task SaveChangesAsync();
    }
}