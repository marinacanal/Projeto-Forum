using Domain.Forum.Entities;

namespace Domain.Forum.Repositories
{
    public interface ICommentRepository 
    {   
        // get all
        Task <List<Comment>> GetAllByPostAsync(Guid postId);

        Task <List<Comment>> GetAllByUserAsync(Guid userId);

        // create
        Task CreateAsync();

        // update
        Task UpdateAsync();

        // delete
        Task DeleteAsync();
    }
}