using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Entities
{
    public class Like
    {
        public int LikeId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int? PostId { get; set; }
        public Post Post { get; set; }
        public int? CommentId { get; set; }
        public Comment Comment { get; set; }
    }
}