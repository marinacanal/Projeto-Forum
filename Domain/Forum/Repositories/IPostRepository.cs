using Domain.Forum.Entities;

namespace Domain.Forum.Repositories 
{
    public interface IPostRepository {

        // get by
        Task<Post> GetByIdAsync(Guid id);
        Task<List<Post>> GetByUserIdAsync(Guid userId);

        // get contains
        Task<List<Post>> GetContainsContentAsync(string content);
        Task<List<Post>> GetContainsTitleAsync(string title);

        // get in
        Task<List<Post>> GetInChannelAsync(Guid channelId);

        // get all
        Task<List<Post>> GetAllAsync();

        // create
        Task CreateAsync(Post post);

        // update
        Task UpdateAsync(Post post);

        // delete
        Task DeleteAsync(Post post);
    }
}