using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using barbieProject.Models;
using Microsoft.EntityFrameworkCore;

namespace barbieProject.Repositories
{
    public class CommentRepository : Repository<Comment>
    {
        private readonly DbContext _context;
        public CommentRepository(DbContext context) : base(context)
        {
            _context = context;
        }
    }
}