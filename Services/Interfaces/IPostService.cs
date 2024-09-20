using barbieProject.Models;

namespace barbieProject.Services.Interfaces
{
    public interface IPostService
    {
        Task<IEnumerable<Post>> GetAllPostsAsync();
        Task<IEnumerable<Post>> GetPostByChannelsAsync(int channelId);
        Task<User> GetPostByIdAsync(int id);
        Task CreatePostAsync(Post post);
        Task UpdatePostAsync(Post post);
        Task DeletePostAsync(int id); 
    }
}