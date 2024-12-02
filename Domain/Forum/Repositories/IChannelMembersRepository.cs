using Domain.Forum.Entities;

namespace Domain.Forum.Repositories
{
    public interface IChannelMembersRepository
    {
        Task <List<ChannelMembers>> GetAllByChannelIdAsync(Guid channelId);
        Task <List<ChannelMembers>> GetAllChannelsByMemberIdAsync(Guid userId);
    }
}