using Domain.Forum.Entities;

namespace Domain.Forum.Repositories
{
    public interface IChannelMembersRepository
    {
        // get all by
        Task <List<Guid>> GetAllMembersByChannelIdAsync(Guid channelId);
        Task <List<Guid>> GetAllChannelsByMemberIdAsync(Guid userId);
    }
}