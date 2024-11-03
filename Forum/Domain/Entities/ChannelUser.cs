using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Entities
{
    public class ChannelUser
    {
        public int UserId { get; set; }
        public int ChannelId { get; set; }
        public Channel Channel { get; set; }
        public User User { get; set; }
    }
}