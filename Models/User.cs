using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace barbieProject.Models
{
    public class User
    {
        private int UserId { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
        public ICollection<Post> Posts { get; set; }
        public ICollection<Like> Likes { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}