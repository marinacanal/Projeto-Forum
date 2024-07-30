using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace barbieProject.Models
{
    public class Comment
    {
        private int CommentId { get; set; }
        public DateTime CreatedCommentDateTime { get; set; } = DateTime.Now;
        public ICollection<Like> Likes { get; set; }
    }
}