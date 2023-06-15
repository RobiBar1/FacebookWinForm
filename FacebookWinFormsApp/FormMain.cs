using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using BasicFacebookFeatures.Properties;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using FacebookLogic;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private const string k_AppId = "226386399872134";
        private static readonly string[] sr_Paremeters =
        {
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
            "user_videos",
        };

        private readonly Image r_BackgroundImage = Resources.facebookLikeImage;
        private readonly ErrorMessageVisitor r_ErrorMessageVisitor;
        private LoginResult m_LoginResult;
        private User m_LoggedInUser;

        public FormMain()
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = 100;
            BackgroundImage = r_BackgroundImage;
            userWasClick = true;
            r_ErrorMessageVisitor = new ErrorMessageVisitor();
        }

        public User LoggedInUser
        {
            get
            {
                return m_LoggedInUser;
            }

            set
            {
                m_LoggedInUser = value;
            }
        }

        private bool userWasClick { get; set; }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns.22aa");

            m_LoginResult = FacebookService.Login(k_AppId, sr_Paremeters);

            if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                LoggedInUser = m_LoginResult.LoggedInUser;
                fetchUserInfo();
            }
            else
            {
                MessageBox.Show(m_LoginResult.ErrorMessage, "Login Failed");
            }

            if (m_LoginResult.AccessToken != null)
            {
                buttonLogin.Text = $"Logged in as {m_LoginResult.LoggedInUser.Name}";
            }
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
                r_ErrorMessageVisitor.ShowLoginError();
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

        private void labelLastName_Click(string i_LastName)
        {
            labelLastName.Visible = true;
            labelLastName.Text = i_LastName;
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
                new Thread(() => FormFactory.CreateForm(eFormType.FormPostTime, this).ShowDialog()).Start();
            }
            else
            {
                r_ErrorMessageVisitor.ShowLoginError();
            }
        }

        private void buttonMyBestFriends_Click(object sender, EventArgs e)
        {
            if (LoggedInUser != null)
            {
                new Thread(() => FormFactory.CreateForm(eFormType.FormFriends, this).ShowDialog()).Start();
            }
            else
            {
                r_ErrorMessageVisitor.ShowLoginError();
            }
        }

        private void buttonActivityStatics_Click(object sender, EventArgs e)
        {
            if (LoggedInUser != null)
            {
                new Thread(() => FormFactory.CreateForm(eFormType.FormActivityStatics, this).ShowDialog()).Start();
            }
            else
            {
                r_ErrorMessageVisitor.ShowLoginError();
            }
        }

        private void buttonBasicUserDetails_Click(object sender, EventArgs e)
        {
            if (LoggedInUser != null)
            {
                new Thread(() => FormFactory.CreateForm(eFormType.FormBasicDetails, this).ShowDialog()).Start();
            }
            else
            {
                r_ErrorMessageVisitor.ShowLoginError();
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            if (m_LoginResult != null && checkBoxRememberMe.Checked)
            {
                AppSetting.Instance.AccessToken = m_LoginResult.AccessToken;
                AppSetting.Instance.SaveToFile();
            }
            else if (!checkBoxRememberMe.Checked)
            {
                AppSetting.DeleteFileIfExist();
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            AppSetting.LoadFromFile();

            if (!string.IsNullOrEmpty(AppSetting.Instance.AccessToken))
            {
                m_LoginResult = FacebookService.Connect(AppSetting.Instance.AccessToken);
                LoggedInUser = m_LoginResult.LoggedInUser;
                fetchUserInfo();
                buttonLogin.Text = $"Logged in as {m_LoginResult.LoggedInUser.Name}";
            }
        }

        private void checkBoxRememberMe_CheckedChanged(object sender, EventArgs e)
        {
            if (m_LoginResult == null && userWasClick)
            {
                userWasClick = !userWasClick;
                r_ErrorMessageVisitor.ShowLoginError();
                checkBoxRememberMe.Checked = false;
            }
            else if (m_LoginResult == null)
            {
                userWasClick = !userWasClick;
            }
        }
    }
}
