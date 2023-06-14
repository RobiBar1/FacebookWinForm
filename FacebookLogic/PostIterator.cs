using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FacebookLogic
{
    public class PostIterator : IEnumerable<Post>
    {
        private readonly ICollection<Post> r_UserPostCollection;

        public PostIterator(ICollection<Post> i_Posts)
        {
            r_UserPostCollection = i_Posts;
        }

        public IEnumerator<Post> GetEnumerator()
        {
            foreach (Post userPosts in r_UserPostCollection)
            {
                yield return userPosts;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
