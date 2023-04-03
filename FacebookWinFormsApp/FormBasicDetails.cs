using System;
using System.Drawing;
using System.Windows.Forms;
using BasicFacebookFeatures.Properties;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class FormBasicDetails : Form
    {
        private const string k_TitleToMessagBox = "Message";
        private readonly FormMain r_FormMain;
        private readonly Image r_BackgroundImage = Resources.facebookDetails;

        public FormBasicDetails(FormMain i_FormMain)
        {
            r_FormMain = i_FormMain;
            InitializeComponent();
            BackgroundImage = r_BackgroundImage;
        }

        private void button_Albums_Click(object sender, EventArgs e)
        {
            fetchAlbums();
        }

        private void fetchAlbums()
        {
            ListBox_Album.Items.Clear();
            ListBox_Album.DisplayMember = "Name";

            foreach (Album album in r_FormMain.LoggedInUser.Albums)
            {
                ListBox_Album.Items.Add(album);
            }

            if (ListBox_Album.Items.Count == 0)
            {
                MessageBox.Show("No Albums to retrieve :(", k_TitleToMessagBox);
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

            foreach (Event fbEvent in r_FormMain.LoggedInUser.Events)
            {
                ListBox_Events.Items.Add(fbEvent);
            }

            if (ListBox_Events.Items.Count == 0)
            {
                MessageBox.Show("No Events to retrieve :(", "Cannot import data");
            }
        }

        private void likedPages_Click(object sender, EventArgs e)
        {
            fetchLikedPages();
        }

        private void fetchLikedPages()
        {
            listBoxLikedPages.Items.Clear();
            listBoxLikedPages.DisplayMember = "Name";

            try
            {
                foreach (Page page in r_FormMain.LoggedInUser.LikedPages)
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
                MessageBox.Show("No liked pages to retrieve :(", k_TitleToMessagBox);
            }
        }

        private void buttonViewPosts_Click(object sender, EventArgs e)
        {
            fetchPosts();
        }

        private void fetchPosts()
        {
            listBoxViewPosts.Items.Clear();

            foreach (Post post in r_FormMain.LoggedInUser.Posts)
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
                    listBoxViewPosts.Items.Add($"[{post.Type}]");
                }
            }

            if (listBoxViewPosts.Items.Count == 0)
            {
                MessageBox.Show("No Posts to retrieve :(", k_TitleToMessagBox);
            }
        }
    }
}
