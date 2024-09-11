using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using barbieProject.Models;
using Microsoft.EntityFrameworkCore;

namespace barbieProject.Repositories
{
    public class LikeRepository : Repository<Like>
    {
        private readonly DbContext _context;
        public LikeRepository(DbContext context) : base(context)
        {
            _context = context;
        }
    }
}