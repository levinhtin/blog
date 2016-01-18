using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogIT.Models
{
    public class Post : AbstractModel
    {
        /// <summary>
        /// Category Post
        /// </summary>
        public int CategoryId { get; set; }

        /// <summary>
        /// Post Title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Post Sumary
        /// </summary>
        public string Sumary { get; set; }

        /// <summary>
        /// Post Content
        /// </summary>
        public string Content { get; set; }

    }
}
