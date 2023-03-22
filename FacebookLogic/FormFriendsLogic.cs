using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Facebook;

namespace FacebookLogic
{
    public class FormFriendsLogic
    {
        private User m_LoggedInUser;
        private int m_MinLikedImage = int.MaxValue;
        private int m_MaxLikedImage = int.MinValue;
        private int m_AvrgLikedImage;
        private bool m_CalcolateHasHAppned = false;

        public FormFriendsLogic(User i_LoggedInUser)
        {
            LoggedInUser = i_LoggedInUser;
        }

        private bool CalculateHasHappened
        { set; get; }
        public int MinLikedImage
        { set; get; }

        public int MaxLikedImage
        { set; get; }

        public int AvrgLikedImage
        { set; get; }
        private User LoggedInUser
        {
            set
            {
                m_LoggedInUser = value;
            }

            get
            {
                return m_LoggedInUser;
            }
        }

        public void CalculateMinMaxAvgLikes()
        {
           

            /*  foreach (Post post in LoggedInUser.Posts)
              {
                  if (post.Type == FacebookWrapper.ObjectModel.Post.eType.photo)
                  {
                      if (post.LikedBy.Count <= m_MinLikedImage)
                      {
                          MinLikedImage = post.LikedBy.Count;
                      }

                      if (post.LikedBy.Count >= MaxLikedImage)
                      {
                          MaxLikedImage = post.LikedBy.Count;
                      }

                      imageCounter++;
                      AvrgLikedImage += post.LikedBy.Count;
                  }
              }

              if (imageCounter != 0)
              {
                  AvrgLikedImage = AvrgLikedImage / imageCounter;
              }

              CalculateHasHappened = true;
            */
        }
    }
}

