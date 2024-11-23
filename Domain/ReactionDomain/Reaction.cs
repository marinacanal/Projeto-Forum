using Domain.ReactionDomain.Enums;
using Domain.UserDomain;

namespace Domain.ReactionDomain
{   
    public class Reaction
    {
        public Guid ReactionId { get; private set; }
        public Guid UserId { get; private set; }
        public User User { get; private set; }

        // post or comment
        public Guid? TargetId { get; private set; }
        public TargetType TargetType { get; private set; }

        // like or dislike
        public ReactionType Type { get; private set; }

        // construtor
        public Reaction(Guid userId, Guid targetId, TargetType targetType, ReactionType reactionType)
        {
            ReactionId = Guid.NewGuid();
            UserId = userId;
            TargetId = targetId;
            TargetType = targetType;
            Type = reactionType;

            if (targetType == TargetType.Post && targetId == Guid.Empty)
                throw new ArgumentException("Post não pode ser vazio!", nameof(targetId));

            if (targetType == TargetType.Comment && targetId == Guid.Empty)
                throw new ArgumentException("Comentário não pode ser vazio!", nameof(targetId));
        }

        // verifica se o usuário curtiu ou descurtiu
        public bool IsLiked() => Type == ReactionType.Like;
        public bool IsDisliked() => Type == ReactionType.Dislike;
    }
}