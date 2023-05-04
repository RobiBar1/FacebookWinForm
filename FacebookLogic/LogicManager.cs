using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FacebookLogic
{
    public sealed class LogicManager
    {
        private readonly ActivityStaticsLogic r_ActivityStaticsLogic;
        private readonly FriendsLogic r_FriendsLogic;
        private readonly MessageSchedulingLogic r_MessageSchedulingLogic;
        private static LogicManager s_LogicMenager;
        private static User s_User = null;
        private bool m_ActivityStaticsCalculate = false;

        public event Action<bool> PostUpload;

        public static LogicManager CreateManager(User i_User)
        {
            s_User = i_User;

            return Instance;
        }

        public static LogicManager Instance
        {
            get
            {
                if (s_LogicMenager == null)
                {
                    s_LogicMenager = new LogicManager(s_User);
                }

                return s_LogicMenager;
            }
        }

        #region FriendsLogic

        public int CalculateMaxLikes()
        {
            r_FriendsLogic.CalculateMinMaxAvgLikes();

            return r_FriendsLogic.MaxLikedImage;
        }

        public int CalculateMinLikes()
        {
            r_FriendsLogic.CalculateMinMaxAvgLikes();

            return r_FriendsLogic.MinLikedImage;
        }

        public int CalculateAvgLikes()
        {
            r_FriendsLogic.CalculateMinMaxAvgLikes();

            return r_FriendsLogic.AvgLikedImage;
        }

        #endregion FriendsLogic

        #region ActivityStaticsLogic

        public int GetMaxActivity()
        {
            if (!m_ActivityStaticsCalculate)
            {
                r_ActivityStaticsLogic.ActivityStatics(); 
            }

            return r_ActivityStaticsLogic.MaxActivity;
        }

        public int GetMaxMonth()
        {
            if (!m_ActivityStaticsCalculate)
            {
                r_ActivityStaticsLogic.ActivityStatics();
            }

            return r_ActivityStaticsLogic.MaxMonth;
        }

        public int GetMinActivity()
        {
            if (!m_ActivityStaticsCalculate)
            {
                r_ActivityStaticsLogic.ActivityStatics();
            }

            return r_ActivityStaticsLogic.MinActivity;
        }

        public int GetMinMonth()
        {
            if (!m_ActivityStaticsCalculate)
            {
                r_ActivityStaticsLogic.ActivityStatics();
            }

            return r_ActivityStaticsLogic.MinMonth;
        }

        #endregion ActivityStaticsLogic

        #region MessageSchedulingLogic

        /*protected virtual void OnPostUpload()
        {
            PostUpload?.Invoke(this);
        }*/

        protected virtual void dsd()
        {
            PostUpload?.Invoke(r_MessageSchedulingLogic.UploadSuccessfully);
        }

        #endregion MessageSchedulingLogic
        private LogicManager(User i_User)
        {
            r_ActivityStaticsLogic = new ActivityStaticsLogic(i_User);
            r_FriendsLogic = new FriendsLogic(i_User);
            r_MessageSchedulingLogic = new MessageSchedulingLogic();
        }
    }
}
