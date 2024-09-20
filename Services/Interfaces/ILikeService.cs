using barbieProject.Models;

namespace barbieProject.Services.Interfaces
{
    public interface ILikeService
    {
        Task LikePostAsync(int postId, int userId);
        Task UnlikePostAsync(int postId, int userId);
        Task LikeCommentAsync(int commentId, int userId);
        Task UnlikeCommentAsync(int commentId, int userId);
    }
}