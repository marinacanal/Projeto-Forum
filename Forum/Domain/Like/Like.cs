namespace Forum.Models
{
    public class Like
    {
        public int LikeId { get; private set; }
        public int UserId { get; private set; }
        public User User { get; private set; }
        public int? PostId { get; private set; }
        public Post Post { get; private set; }
        public int? CommentId { get; private set; }
        public Comment Comment { get; private set; }
    }
}