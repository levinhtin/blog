using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogIT.Models;

namespace BlogIT.Repository
{
    public interface IPostRepository
    {
        IEnumerable<Post> AllPost { get; }
        void Add(Post item);
        Post GetById(int id);
        bool Delete(int id);
    }
}
