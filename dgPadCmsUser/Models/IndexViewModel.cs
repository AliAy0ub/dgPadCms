using dgPadCms.Models;
using System.Collections.Generic;

namespace dgPadCmsUser.Models
{
    public class IndexViewModel
    {
        public List<Post> lastFivePosts { get; set; }
        public List<PostType> firstPostType { get; set; }
        public List<Post> secondPostType { get; set; }
        public List<Post> thirdPostType { get; set; }
        public List<Term> indexTerms { get; set; }
    }
}
