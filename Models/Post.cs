using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace barbieProject.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public string MidiaPost { get; set; }
        public string TextPost { get; set; }
        public DateTime DateTimePostCreated { get; set; } = DateTime.Now;
        public ICollection<Like> Likes { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}