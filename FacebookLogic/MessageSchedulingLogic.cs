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

        private User loggedInUser { get; set; }

        private string userHours
        {
            get
            {
                return m_UserHours;
            }

            set
            {
                if (!string.IsNullOrEmpty(value) || int.TryParse(value, out int o_IntValue))
                {
                    intHours = int.Parse(value);
                }
                else
                {
                    throw new ArgumentException("The number of hours cannot be string or empty, try again with a number.");
                }
            }
        }

        private string userMessage
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

        private int intHours { get; set; }

        private System.Timers.Timer timerToUploadPost
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
            loggedInUser = i_User;
            userHours = i_Hours;
            userMessage = i_Text;
            timerToUploadPost = new System.Timers.Timer(0.01);
            timerToUploadPost.Elapsed += timerElapsed;
            timerToUploadPost.Enabled = true;
            timerToUploadPost.Start();
        }

        private void timerElapsed(object sender, ElapsedEventArgs e)
        {
            try
            {
                timerToUploadPost.Stop();
                loggedInUser.PostStatus(userMessage);
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
