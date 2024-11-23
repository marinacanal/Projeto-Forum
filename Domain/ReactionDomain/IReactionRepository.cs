namespace Domain.ReactionDomain
{
    public interface IReactionRepository
    {
        Task<Reaction> GetByTargetType();
    }
}