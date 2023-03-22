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
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using FacebookLogic;


namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {

        private const string k_LoginError = "First you need to be logged in";
        private const string k_AppId = "226386399872134";
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
        private LoginResult m_LoginResult;
        private User m_LoggedInUser;
        private Status m_StatusToPost;
        public FormMain()
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = 100;
        }

        public Status StatusToPost
        {
            get { return m_StatusToPost; }
            set { m_StatusToPost = value;}
        }

        public LoginResult LoginResult
        {
            set
            {
                m_LoginResult = value;
            }

            get
            {
                return m_LoginResult;
            }
        }

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
            Clipboard.SetText("design.patterns20cc");
            LoginResult = FacebookService.Connect("EAADN5bDyRIYBAHkwSPl9RrDf4jG4HiGF5k05LwoHxExTNGg4LP6Fbgbc4ykFfkiKY7qxVSJiHGLe5Pfo2t8wWcqkZBL8QtbBGdWaW6ZAxbYd7G9fQHkzLzYyneebcIkOaZAIYOYt4Ud0aNeqZCKISqplgzbuWlEoPs792n11Gg33LtOsS0hkIjLyHKn0WeYZD");

            /* LoginResult LoginResult = FacebookService.Login(k_AppId,sr_Paremeters)*/

            if (!string.IsNullOrEmpty(LoginResult.AccessToken))
            {
                LoggedInUser = LoginResult.LoggedInUser;

                fetchUserInfo();
            }
            else
            {
                MessageBox.Show(LoginResult.ErrorMessage, "Login Failed");
            }

            buttonLogin.Text = $"Logged in as {LoginResult.LoggedInUser.Name}";
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            buttonLogin.Text = "Login";
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

        private void button1_Click(object sender, EventArgs e)
        {
            fetchAlbums();
        }

        private void fetchAlbums()
        {
            ListBox_Album.Items.Clear();
            ListBox_Album.DisplayMember = "Name";

            foreach (Album album in m_LoggedInUser.Albums)
            {
                ListBox_Album.Items.Add(album);
                //album.ReFetch(DynamicWrapper.eLoadOptions.Full);
            }
            if (ListBox_Album.Items.Count == 0)
            {
                MessageBox.Show("No Albums to retrieve :(");
            }

        }

        private void button_Events_Click(object sender, EventArgs e)
        {
            fetchEvents();
        }

        private void fetchEvents()
        {
            ListBox_Events.Items.Clear();
            ListBox_Events.DisplayMember = "Name";

            foreach (Event fbEvent in m_LoggedInUser.Events)
            {
                ListBox_Events.Items.Add(fbEvent);
            }

            if (ListBox_Events.Items.Count == 0)
            {
                MessageBox.Show("No Events to retrieve :(");
            }
        }

        private void ListBox_Events_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBox_Events.SelectedItems.Count == 1)
            {
                Event selectedEvent = ListBox_Events.SelectedItem as Event;
            }
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

        private void buttonLikedPages_Click(object sender, EventArgs e)
        {
            fetchLikedPages();
        }

        private void fetchLikedPages()
        {
            listBoxLikedPages.Items.Clear();
            listBoxLikedPages.DisplayMember = "Name";

            try
            {
                foreach (Page page in m_LoggedInUser.LikedPages)
                {
                    listBoxLikedPages.Items.Add(page);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (listBoxLikedPages.Items.Count == 0)
            {
                MessageBox.Show("No liked pages to retrieve :(");
            }
        }

        private void postTiming_Click(object sender, EventArgs e)
        {
            MessageScheduling messageScheduling = new MessageScheduling();

            try
            {
                messageScheduling.PostUpload += new Action<MessageScheduling>(ShowOnUiThatPostIsUpload);
                messageScheduling.SchedulingMessage(LoggedInUser, userPost.Text, userHours.Text);

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void ShowOnUiThatPostIsUpload(MessageScheduling i_MessageScheduling)
        {
            if(i_MessageScheduling.UploadSuccessfully)
            {
                MessageBox.Show("Post was uploaded");
            }
            else
            {
                MessageBox.Show("Post wasn't uploaded, please try again");
            }
        }

        private void fetchPosts()
        {
            listBoxViewPosts.Items.Clear();

            foreach (Post post in m_LoggedInUser.Posts)
            {
                if (post.Message != null)
                {
                    listBoxViewPosts.Items.Add(post.Message);
                }
                else if (post.Caption != null)
                {
                    listBoxViewPosts.Items.Add(post.Caption);
                }
                else
                {
                    listBoxViewPosts.Items.Add(string.Format("[{0}]", post.Type));
                }
            }

            if (listBoxViewPosts.Items.Count == 0)
            {
                MessageBox.Show("No Posts to retrieve :(");
            }
        }

        private void buttonViewPosts_Click(object sender, EventArgs e)
        {
            fetchPosts();
        }

        private void buttonMyBestFriends_Click(object sender, EventArgs e)
        {
            if(LoggedInUser != null)
            {
                new FormFriends(this).ShowDialog();
            }

            else
            {
                MessageBox.Show(k_LoginError);
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
                MessageBox.Show(k_LoginError);
            }
        }
    }
}
