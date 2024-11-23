using Domain.UserDomain;

namespace Domain.ChannelDomain
{
    public class ChannelMembers
    {
        public int UserId { get; set; }
        public int ChannelId { get; set; }
        public Channel Channel { get; set; }
        public User User { get; set; }
    }
}