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

        // relacoes
        public IReadOnlyCollection<Channel> ChannelsCreated { get; private set; } 
        public IReadOnlyCollection<ChannelMembers> JoinedChannels { get; private set; } 
        public IReadOnlyCollection<Post> Posts { get; private set; } 
        public IReadOnlyCollection<Like> Likes { get; private set; } 
        public IReadOnlyCollection<Comment> Comments { get; private set; } 

        // construtor
        public User(Username username, Email useremail, Password userpassword) {
            UserId = Guid.NewGuid();
            CreatedAt = DateTime.UtcNow;
            UserName = username;
            Email = useremail;
            Password = userpassword;

            ChannelsCreated = new List<Channel>();
            JoinedChannels = new List<ChannelMembers>();
            Posts = new List<Post>();
            Comments = new List<Comment>();
            Likes = new List<Like>();
        }

        // updates
        public void UpdateUserName(Username username) => UserName = username;
        public void UpdateUserEmail(Email email) => Email = email;
        public void UpdatePassword(Password password) => Password = password;
    }
}