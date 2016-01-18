using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogIT.Models;

namespace BlogIT.Repository
{
    public class PostRepository : IPostRepository, IDisposable
    {
        private readonly ApplicationDbContext _context;
        public PostRepository(ApplicationDbContext dbcontext)
        {
            _context = dbcontext;
        }

        public IEnumerable<Post> AllPost
        {
            get
            {
                return _context.Posts;
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
