using Domain.Forum.Entities;
using Domain.Forum.Enums;

namespace Domain.Forum.Repositories
{
    public interface IReactionRepository
    {  
        // get by
        Task <Reaction> GetReactionTypeByTargetTypeAndUserAsync(Guid userId, Guid targetId, TargetType targetType);

        // get all
        Task <List<Reaction>> GetAllByTargetTypeAsync(Guid targetId, TargetType targetType); // post or comment 

        // create
        Task CreateAsync(Reaction reaction);

        // delete
        Task DeleteAsync(Reaction reaction);
    }
}