using System;
using System.CodeDom;
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
        private static readonly object sr_LockObj = new object();
        private static LogicManager s_LogicMenager;
        private static User s_User;

        public static LogicManager CreateManager(User i_User)
        {
            s_User = i_User;

            return Instance;
        } 
        
        public static LogicManager Instance
        {
            get
            {
                lock (sr_LockObj)
                {
                    if (s_LogicMenager == null)
                    {
                        s_LogicMenager = new LogicManager(s_User);
                    }
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
            checkIfCalculated();

            return r_ActivityStaticsLogic.MaxActivity;
        }

        public int GetMaxMonth()
        {
            checkIfCalculated();

            return r_ActivityStaticsLogic.MaxMonth;
        }

        public int GetMinActivity()
        {
            checkIfCalculated();

            return r_ActivityStaticsLogic.MinActivity;
        }

        private void checkIfCalculated()
        {
            if (!r_ActivityStaticsLogic.IsCalculated)
            {
                r_ActivityStaticsLogic.ActivityStatics();
            }
        }

        public int GetMinMonth()
        {
            checkIfCalculated();

            return r_ActivityStaticsLogic.MinMonth;
        }

        #endregion ActivityStaticsLogic
        
        private LogicManager(User i_User)
        {
            r_ActivityStaticsLogic = new ActivityStaticsLogic(i_User);
            r_FriendsLogic = new FriendsLogic(i_User);
        }
    }
}
