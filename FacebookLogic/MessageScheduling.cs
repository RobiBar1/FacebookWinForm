using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;


namespace FacebookLogic
{
    public class MessageScheduling
    {
        private string m_UserMessage;
        private DateTime m_CurrentDate;

        public DateTime CurrentDate
        {
            get
            {
                return m_CurrentDate;
            }
            set
            {
                m_CurrentDate = value;
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
                if (string.IsNullOrEmpty(value))
                {
                    m_UserMessage = value;
                }
                else
                {
                    throw new ArgumentException("User message cannot be null or empty.");
                }
            }
        }



        public void SchedulingMessage(string i_UserMesssage, int i_UserHours)
        {
            CurrentDate = DateTime.Now;


        }




    }
}
