using FacebookWrapper.ObjectModel;

namespace FacebookLogic
{
    public class FriendsLogic
    {
        private readonly User r_LoggedInUser;

        public FriendsLogic(User i_LoggedInUser)
        {
            r_LoggedInUser = i_LoggedInUser;
            AvgLikedImage = 0;
        }

        private bool calculateHasHappened
        { get; set; } = false;

        public int MinLikedImage
        { get; set; } = int.MaxValue;

        public int MaxLikedImage
        { get; set; } = int.MinValue;

        public int AvgLikedImage
        { get; set; }

        public void CalculateMinMaxAvgLikes()
        {
            int imageCounter = 0;

            foreach (Post post in r_LoggedInUser.Posts)
            {
                if (post.Type == Post.eType.photo)
                {
                    if (post.LikedBy.Count <= MinLikedImage)
                    {
                        MinLikedImage = post.LikedBy.Count;
                    }

                    if (post.LikedBy.Count >= MaxLikedImage)
                    {
                        MaxLikedImage = post.LikedBy.Count;
                    }

                    imageCounter++;
                    AvgLikedImage += post.LikedBy.Count;
                }
            }

            if (imageCounter != 0)
            {
                AvgLikedImage /= imageCounter;
            }

            calculateHasHappened = true;
        }
    }
}