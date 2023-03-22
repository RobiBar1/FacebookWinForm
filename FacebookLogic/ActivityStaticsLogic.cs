using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace FacebookLogic
{
    public class ActivityStaticsLogic
    {
        private readonly User r_UserLoggedIn;
        private int m_MaxActivity;
        private int m_MaxMonth;
        private int m_MinMonth;
        private int m_MinActivity;

        public ActivityStaticsLogic(User i_UserLoggedIn)
        {
            r_UserLoggedIn = i_UserLoggedIn;
        }

        public int MaxMonth
        {
            get
            {
                return m_MaxMonth;
            }
            set
            {
                m_MaxMonth = value;
            }
        }
        public int MinMonth
        {
            get
            {
                return m_MinMonth;
            }
            set
            {
                m_MinMonth = value;
            }
        }
        public int MinActivity
        {
            get
            {
                return m_MinActivity;
            }
            set
            {
                m_MinActivity = value;
            }
        }
        public int MaxActivity
        {
            get
            {
                return m_MaxActivity;
            }
            set
            {
                m_MaxActivity = value;
            }
        }
        public void ActivityStatics()
        {
            m_MinActivity = int.MaxValue;
            m_MaxActivity = int.MinValue;
            int[] postsListMonths = new int[13];

            foreach (Post post in r_UserLoggedIn.Posts)
            {
                DateTime postUpdateTime = (DateTime)post.UpdateTime;
                postsListMonths[postUpdateTime.Month]++;
            }

            for (int i = 1; i <= 12; i++)
            {
                if (postsListMonths[i] > m_MaxActivity)
                {
                    m_MaxActivity = postsListMonths[i];
                    m_MaxMonth = i;
                }

                if (postsListMonths[i] < m_MinActivity)
                {
                    m_MinActivity = postsListMonths[i];
                    m_MinMonth = i;
                }

            }
        }
    }
}
