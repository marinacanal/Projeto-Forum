using Domain.ChannelDomain;
using Domain.CommentDomain;
using Domain.PostDomain.ValueObjects;
using Domain.ReactionDomain;
using Domain.UserDomain;

namespace Domain.PostDomain
{
    public class Post
    {
        public Guid PostId { get; private set; }
        public Title Title { get; private set; }
        public Content Content { get; private set; }
        public DateTime CreatedAt { get; private set; }

        // modelos relacionados
        public Guid UserId { get; private set; }
        public User User { get; private set; }
        public Guid ChannelId { get; private set; }
        public Channel Channel { get; private set; }       
        public ICollection<Reaction> Reactions { get; private set; }
        public ICollection<Comment> Comments { get; private set; }

        public Post(Title title, Content content, Guid userid) {
            PostId = Guid.NewGuid();
            CreatedAt = DateTime.UtcNow;
            UserId = userid;
            Title = title; 
            Content = content;

            Comments = new List<Comment>();
            Reactions = new List<Reaction>();
        }

        public void UpdatePost(Title title, Content content) {
            Title = title;
            Content = content;
        }

        public void AddComment(Comment comment) {
            if (comment == null) throw new ArgumentNullException(nameof(comment));

            Comments.Add(comment);
        }

        public void AddLike(Reaction reaction) {
            if (reaction == null) throw new ArgumentNullException(nameof(reaction));
            
            Reactions.Add(reaction);
        }
    }
}