using Forum.Models;

namespace Forum.Interfaces
{
    public interface ILikeService
    {
        Task LikePostAsync(int postId, int userId);
        Task UnlikePostAsync(int postId, int userId);
        Task LikeCommentAsync(int commentId, int userId);
        Task UnlikeCommentAsync(int commentId, int userId);
    }
}