namespace Forum.Models
{
    public class Post
    {
        public Guid PostId { get; private set; }
        public string Title { get; private set; }
        public string Content { get; private set; }
        public DateTime CreatedAt { get; private set; }

        // modelos relacionados
        public Guid UserId { get; private set; }
        public User User { get; private set; }
        public Guid ChannelId { get; private set; }
        public Channel Channel { get; private set; }       
        public ICollection<Like> Likes { get; private set; }
        public ICollection<Comment> Comments { get; private set; }

        public Post(string title, string content, Guid userid) {
            PostId = Guid.NewGuid();
            CreatedAt = DateTime.UtcNow;
            UserId = userid;
            Title = title ?? throw new ArgumentNullException(nameof(title));
            Content = content ?? throw new ArgumentNullException(nameof(content));

            Comments = new List<Comment>();
            Likes = new List<Like>();
        }

        public void UpdatePost(string title, string content) {
            Title = title ?? throw new ArgumentNullException(nameof(title));
            Content = content ?? throw new ArgumentNullException(nameof(content));
        }

        public void AddComment(Comment comment) {
            if (comment == null) throw new ArgumentNullException(nameof(comment));

            Comments.Add(comment);
        }

        public void AddLike(Like like) {
            if (like == null) throw new ArgumentNullException(nameof(like));
            
            Likes.Add(like);
        }
    }
}