using System;
using System.Timers;
using FacebookWrapper.ObjectModel;

namespace FacebookLogic
{
    public class MessageSchedulingLogic
    {
        private string m_UserMessage;
        private string m_UserHours;
        private System.Timers.Timer m_TimerToUploadPost = null;

        public event Action<MessageSchedulingLogic> PostUpload;

        public bool UploadSuccessfully { get; set; }

        private User LoggedInUser { get; set; }

        private string UserHours
        {
            get
            {
                return m_UserHours;
            }

            set
            {
                if (!string.IsNullOrEmpty(value) || int.TryParse(value, out int IntHours))
                {
                    IntHours = int.Parse(value);
                }
                else
                {
                    throw new ArgumentException("The number of hours cannot be string or empty, try again with a number.");
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
                    throw new ArgumentException("User message cannot be empty.");
                }
            }
        }

        private int IntHours { get; set; }

        private System.Timers.Timer TimerToUploadPost
        {
            get
            {
                return m_TimerToUploadPost;
            }

            set
            {
                m_TimerToUploadPost = value;
            }
        }

        public void SchedulingMessage(User i_User, string i_Text, string i_Hours)
        {
            LoggedInUser = i_User;
            UserHours = i_Hours;
            UserMessage = i_Text;
            TimerToUploadPost = new System.Timers.Timer(0.01);
            TimerToUploadPost.Elapsed += timerElapsed;
            TimerToUploadPost.Enabled = true;
            TimerToUploadPost.Start();
        }

        private void timerElapsed(object sender, ElapsedEventArgs e)
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
            {
                OnTimerEndPostUpload();
            }
        }

        protected virtual void OnTimerEndPostUpload()
        {
            PostUpload?.Invoke(this);
        }
    }
}
