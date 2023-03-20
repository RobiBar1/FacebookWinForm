using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using FacebookWrapper.ObjectModel;


namespace FacebookLogic
{
    public class MessageScheduling
    {
        private string m_UserMessage;
        private string m_UserHours;
        private int m_IntHours;
        private User m_LoggedInUser ;

        public User LoggedInUser
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
        public string UserHours
        {
            get
            {
                return m_UserHours;
            }
            set
            {
                if (!string.IsNullOrEmpty(value) || int.TryParse(value, out int m_IntHours))
                {
                    m_UserMessage = value;
                }
                else
                {
                    throw new ArgumentException("User message cannot be string, try again with a number .");
                }
            }
        }

        public string UserMessage
        {
            get
            {
                return m_UserMessage;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    m_UserMessage = value;
                }
                else
                {
                    throw new ArgumentException("User message cannot be null or empty.");
                }
            }
        }

        public int IntHours
        {
            get
            {
                return m_IntHours;
            }
        }

        public void SchedulingMessage(User i_User)
        {
            LoggedInUser = i_User;
            Timer timer = new Timer(IntHours * 60*60*1000); 
            timer.Elapsed += TimerElapsed;
            timer.Enabled = true;
        }

        static void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            Status postStatus = new Status();
            postStatus.Message = UserMessage;
        }


    }

    
}
