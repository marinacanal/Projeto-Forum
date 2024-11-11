using Forum.Models;

namespace Forum.Interfaces
{
    public interface IChannelService
    {
        Task<IEnumerable<Channel>> GetAllChannelsAsync();
        Task<Channel> GetChannelByIdAsync(int id);
        Task CreateChannelAsync(Channel channel);
        Task UpdateChannelAsync(Channel channel);
        Task DeleteChannelAsync(int id);
        Task JoinChannelAsync(int channelId, int userId);
        Task LeaveChannelAsync(int channelId, int userId);
    }
}