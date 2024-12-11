using Domain.Forum.Entities;

namespace Domain.Forum.Repositories
{
    public interface ICommentRepository 
    {   
        // get all by
        Task <List<Comment>> GetAllByPostAsync(Guid postId);

        Task <List<Comment>> GetAllByUserAsync(Guid userId);

        // create
        Task CreateAsync(Comment comment);

        // update
        Task UpdateAsync(Comment comment);

        // delete
        Task DeleteAsync(Comment comment);
    }
}