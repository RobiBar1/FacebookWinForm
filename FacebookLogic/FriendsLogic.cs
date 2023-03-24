using FacebookWrapper.ObjectModel;


namespace FacebookLogic
{
    public class FriendsLogic
    {
        private readonly User m_LoggedInUser;
        private int m_MinLikedImage = int.MaxValue;
        private int m_MaxLikedImage = int.MinValue;
        private int m_AvrgLikedImage;
        private bool m_CalcolateHasHAppned = false;

        public FriendsLogic(User i_LoggedInUser)
        {
            m_LoggedInUser = i_LoggedInUser;
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
            get
            {
                return m_LoggedInUser;
            }
        }

        public void CalculateMinMaxAvgLikes()
        {
            int imageCounter = 0;

            foreach (Post post in LoggedInUser.Posts)
            {
                if (post.Type == Post.eType.photo)
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

        }
    }
}

