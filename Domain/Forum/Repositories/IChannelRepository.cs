using Domain.Forum.Entities;
using Domain.Forum.ValueObjects;

namespace Domain.Forum.Repositories
{
    public interface IChannelRepository
    {
        // get by
        Task <Channel> GetByIdAsync(Guid channelId);

        // get all
        Task <List<Channel>> GetAllByUserIdAsync(Guid userId);

        // get contains
        Task <List<Channel>> GetContainsNameAsync(ChannelName name);
        Task <List<Channel>> GetContainsDescriptioneAsync(ChannelDescription description);

        // create
        Task CreateAsync();

        // update
        Task UpdateAsync();

        // delete
        Task DeleteAsync();
    }
}