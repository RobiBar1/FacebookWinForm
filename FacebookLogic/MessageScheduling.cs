using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;


namespace FacebookLogic
{
    public class MessageScheduling
    {
        private string m_UserMessage;
        private string m_UserHours;
        private int m_IntHours;
        private User m_LoggedInUser;
        private bool m_UploadSuccessfully;
        private System.Timers.Timer m_TimerToUploadPost = null;
        public event Action<MessageScheduling> PostUpload;

        public bool UploadSuccessfully
        {
            get { return m_UploadSuccessfully; }
            set { m_UploadSuccessfully = value; }
        }

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
        private string UserHours
        {
            get
            {
                return m_UserHours;
            }
            set
            {
                if (!string.IsNullOrEmpty(value) || int.TryParse(value, out int m_IntHours))
                {
                    IntHours = int.Parse(value);
                }
                else
                {
                    throw new ArgumentException("User message cannot be string, try again with a number .");
                }
            }
        }

        private string UserMessage
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

        private int IntHours
        {
            get
            {
                return m_IntHours;
            }
            set { m_IntHours = value; }
        }

        private System.Timers.Timer TimerToUploadPost 
        {
            get { return m_TimerToUploadPost; }
            set { m_TimerToUploadPost = value; }
        }

        public void SchedulingMessage(User i_User, string i_Text, string i_Hours)
        {
            LoggedInUser = i_User;
            UserHours = i_Hours;
            UserMessage = i_Text;
            TimerToUploadPost = new System.Timers.Timer(IntHours * 10 * 1000);//IntHours * 60 * 1000 * 60 ); the real forumola for hours.
            TimerToUploadPost.Elapsed += TimerElapsed;
            TimerToUploadPost.Enabled = true;
            TimerToUploadPost.Start();
        }

        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            try
            {
                TimerToUploadPost.Stop();
                Status postStatus = LoggedInUser.PostStatus(UserMessage);
                UploadSuccessfully = true;
            }
            catch (Exception ex)
            {
                UploadSuccessfully = false;
            }
            finally
            { OnTimerEndPostUpload(); }

        }

        protected virtual void OnTimerEndPostUpload()
        {
            PostUpload?.Invoke(this);
        }

    }
}
