using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using BasicFacebookFeatures.Properties;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using FacebookLogic;


namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private readonly Image m_BackgroundImage = Resources.facebookLikeImage;
        private static readonly string[] sr_Paremeters = {
            "email",
            "public_profile",
            "user_age_range",
            "user_birthday",
            "user_events",
            "user_friends",
            "user_gender",
            "user_hometown",
            "user_likes",
            "user_link",
            "user_location",
            "user_photos",
            "user_posts",
            "user_videos" };
        private const string k_LoginError = "First you need to be logged in";
        private const string k_LoginErrorTitle = "Not connected";
        private const string k_AppId = "226386399872134";
        private LoginResult m_LoginResult;
        private User m_LoggedInUser;
        public FormMain()
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = 100;
            BackgroundImage = m_BackgroundImage;
            AppSetting = new AppSetting();
        }

        private AppSetting AppSetting { set; get; }

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

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("0503333424");
            m_LoginResult = FacebookService.Connect("EAADN5bDyRIYBAHkwSPl9RrDf4jG4HiGF5k05LwoHxExTNGg4LP6Fbgbc4ykFfkiKY7qxVSJiHGLe5Pfo2t8wWcqkZBL8QtbBGdWaW6ZAxbYd7G9fQHkzLzYyneebcIkOaZAIYOYt4Ud0aNeqZCKISqplgzbuWlEoPs792n11Gg33LtOsS0hkIjLyHKn0WeYZD");

            //m_LoginResult = FacebookService.Login(k_AppId, sr_Paremeters);

            if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                LoggedInUser = m_LoginResult.LoggedInUser;
                fetchUserInfo();
            }
            else
            {
                MessageBox.Show(m_LoginResult.ErrorMessage, "Login Failed");
            }

            buttonLogin.Text = $"Logged in as {m_LoginResult.LoggedInUser.Name}";
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {

            if (LoggedInUser != null)
            {
                FacebookService.LogoutWithUI();
                buttonLogin.Text = "Login";
                initializeBasicDetails();
            }

            else
            {
                MessageBox.Show(k_LoginError, k_LoginErrorTitle);
            }
        }

        private void initializeBasicDetails()
        {
            LoggedInUser = null;
            m_LoginResult = null;

            labelLastName.Visible = false;
            labelLastName.Text = string.Empty;
            labelFirstName.Visible = false;
            labelFirstName.Text = string.Empty;
            labelBirthday.Visible = false;
            labelBirthday.Text = string.Empty;
            pictureBoxProfile.Image = null;
        }

        private void fetchUserInfo()
        {
            pictureBoxProfile.LoadAsync(LoggedInUser.PictureNormalURL);
            if (LoggedInUser.Posts.Count > 0)
            {
                textBoxStatus.Text = m_LoggedInUser.Posts[0].Message;
            }

            labelLastName_Click(LoggedInUser.LastName);
            labelFirstName_Click(LoggedInUser.FirstName);
            labelBirthday_Click(LoggedInUser.Birthday);
        }

        private void labelLastName_Click(string i_lastName)
        {
            labelLastName.Visible = true;
            labelLastName.Text = i_lastName;
        }
        
        private void labelFirstName_Click(string i_FirstName)
        {
            labelFirstName.Visible = true;
            labelFirstName.Text = i_FirstName;
        }

        private void labelBirthday_Click(string i_Birthday)
        {
            labelBirthday.Visible = true;
            labelBirthday.Text = i_Birthday;
        }

        private void postTiming_Click(object sender, EventArgs e)
        {
            if (LoggedInUser != null)
            {
                MessageScheduling messageScheduling = new MessageScheduling();

                try
                {
                    messageScheduling.PostUpload += new Action<MessageScheduling>(showOnUiThatPostIsUpload);
                    messageScheduling.SchedulingMessage(LoggedInUser, userPost.Text, userHours.Text);

                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Error");
                }
            }
            else
            {
                MessageBox.Show(k_LoginError, k_LoginErrorTitle);
            }

        }

        private void showOnUiThatPostIsUpload(MessageScheduling i_MessageScheduling)
        {
            MessageBox.Show(i_MessageScheduling.UploadSuccessfully
                ? "Post was uploaded"
                : "Post wasn't uploaded, this information cannot currently be uploaded from Facebook servers", "Post information");
        }

        private void buttonMyBestFriends_Click(object sender, EventArgs e)
        {
            if(LoggedInUser != null)
            {
                new FormFriends(this).ShowDialog();
            }

            else
            {
                MessageBox.Show(k_LoginError, k_LoginErrorTitle);
            }
        }

        private void buttonActivityStatics_Click(object sender, EventArgs e)
        {
            if (LoggedInUser != null)
            {
                new FormActivityStatics(this).ShowDialog();
            }

            else
            {
                MessageBox.Show(k_LoginError, k_LoginErrorTitle);
            }
        }

        private void buttonBasicUserDetails_Click(object sender, EventArgs e)
        {
            if (LoggedInUser != null)
            {
                new FormBasicDetails(this).ShowDialog();
            }

            else
            {
                MessageBox.Show(k_LoginError, k_LoginErrorTitle);
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            if (m_LoginResult != null && checkBoxRememberMe.Checked)
            {
                AppSetting.AccessToken = m_LoginResult.AccessToken;
                //AppSetting.FacebookOAuthResult = m_LoginResult.FacebookOAuthResult;
                AppSetting.saveToFile();
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            AppSetting = AppSetting.LoadFromFile();

            if(!string.IsNullOrEmpty(AppSetting.AccessToken))
            {
                m_LoginResult = FacebookService.Connect(AppSetting.AccessToken);
                //m_LoginResult.FacebookOAuthResult = AppSetting.FacebookOAuthResult;
                LoggedInUser = m_LoginResult.LoggedInUser;
                fetchUserInfo();
                buttonLogin.Text = $"Logged in as {m_LoginResult.LoggedInUser.Name}";
            }
        }
    }
}
