using Domain.PostDomain;
using Domain.UserDomain;

namespace Domain.ChannelDomain
{
    public class Channel
    {
        public int ChannelId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public int CreatorId { get; set; }
        public User Creator { get; set; }
        public ICollection<ChannelMembers> Members { get; set; }
        public ICollection<Post> Posts { get; set; }
    }
}