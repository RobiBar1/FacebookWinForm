using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
        }

        private LoginResult m_LoginResult;
        private User m_LoggedInUser;

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

            FacebookWrapper.LoginResult LoginResult = FacebookService.Login(
                    "226386399872134",
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
                    "user_videos");

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
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fetchAlbums();
        }

        private void fetchAlbums()
        {
            ListBox_Album.Items.Clear();
            ListBox_Album.DisplayMember = "Name";

            if (ListBox_Album.Items.Count == 0)
            {
                MessageBox.Show("No Albums to retrieve :(");
            }
            else
            {
                foreach (Album album in m_LoggedInUser.Albums)
                {
                    ListBox_Album.Items.Add(album);
                    //album.ReFetch(DynamicWrapper.eLoadOptions.Full);
                }
            }
        }

        private void ListBox_Album_Clicked(object sender, EventArgs e)
        {
            
        }

        private void button_Events_Click(object sender, EventArgs e)
        {
            fetchEvents();
        }

        private void fetchEvents()
        {
            ListBox_Events.Items.Clear();
            ListBox_Events.DisplayMember = "Name";
            
            foreach (Event fbEvent in LoggedInUser.Events)
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

        }
    }
}
