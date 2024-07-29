using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace barbieProject.Models
{
    public class Post
    {
        private int PostId { get; set; }
        public string MidiaPost { get; set; }
        public string TextoPost { get; set; }
        public ICollection<Like> Likes { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}