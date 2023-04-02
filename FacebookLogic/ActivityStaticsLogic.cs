using System;
using FacebookWrapper.ObjectModel;

namespace FacebookLogic
{
    public class ActivityStaticsLogic
    {
        private readonly User r_UserLoggedIn;

        public ActivityStaticsLogic(User i_UserLoggedIn)
        {
            r_UserLoggedIn = i_UserLoggedIn;
        }

        public int MaxMonth { get; set; }

        public int MinMonth { get; set; }

        public int MinActivity { get; set; }

        public int MaxActivity { get; set; }

        public void ActivityStatics()
        {
            MinActivity = int.MaxValue;
            MaxActivity = int.MinValue;
            int numberOfMonth = 12;
            int[] postsListMonths = new int[numberOfMonth + 1];

            foreach (Post post in r_UserLoggedIn.Posts)
            {
                DateTime postUpdateTime = (DateTime)post.UpdateTime;
                postsListMonths[postUpdateTime.Month]++;
            }

            for (int i = 1; i <= numberOfMonth; i++)
            {
                if (postsListMonths[i] > MaxActivity)
                {
                    MaxActivity = postsListMonths[i];
                    MaxMonth = i;
                }

                if (postsListMonths[i] < MinActivity)
                {
                    MinActivity = postsListMonths[i];
                    MinMonth = i;
                }
            }
        }
    }
}
