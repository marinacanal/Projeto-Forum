using Forum.Domain;

namespace Forum.Models
{
    public class User
    {
        public Guid UserId { get; private set; }

        // objetos de valor
        public Username UserName { get; private set; }
        public Email Email { get; private set; }
        public Password Password { get; private set; }

        // atributos do dominio
        public string ProfilePictureUrl { get; private set; }
        public DateTime CreatedAt { get; private set; }

        // para navegacao com modelos relacionados
        public ICollection<Channel> ChannelsCreator { get; private set; }
        public ICollection<ChannelMembers> ChannelsMember { get; private set; }
        public ICollection<Post> Posts { get; private set; }
        public ICollection<Like> Likes { get; private set; }
        public ICollection<Comment> Comments { get; private set; }

        // construtor
        public User(Username username, Email useremail, Password userpassword) {
            UserId = Guid.NewGuid();
            UserName = username;
            Email = useremail;
            Password = userpassword;
        }
    }
}