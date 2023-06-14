using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicFacebookFeatures.Properties;
using FacebookLogic;
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
            new Thread(fetchAlbums).Start();
        }

        private void fetchAlbums()
        {
            ListBox_Album.Invoke(new Action(() => ListBox_Album.Items.Clear()));

            ListBox_Album.Invoke(new Action(() => ListBox_Album.DisplayMember = "Name"));

            foreach (Album album in r_FormMain.LoggedInUser.Albums)
            {
                ListBox_Album.Invoke(new Action(() => ListBox_Album.Items.Add(album)));
            }

            if (ListBox_Album.Items.Count == 0)
            {
                MessageBox.Show("No Albums to retrieve :(", k_TitleToMessagBox);
            }
        }

        private void button_Events_Click(object sender, EventArgs e)
        {
            new Thread(fetchEvents).Start();
        }

        private void fetchEvents()
        {
            ListBox_Events.Invoke(new Action(() => ListBox_Events.Items.Clear()));

            ListBox_Events.Invoke(new Action(() => ListBox_Events.DisplayMember = "Name"));

            foreach (Event fbEvent in r_FormMain.LoggedInUser.Events)
            {
                ListBox_Events.Invoke(new Action(() => ListBox_Events.Items.Add(fbEvent)));
            }

            if (ListBox_Events.Items.Count == 0)
            {
                MessageBox.Show("No Events to retrieve :(", "Cannot import data");
            }
        }

        private void likedPages_Click(object sender, EventArgs e)
        {
            new Thread(fetchLikedPages).Start();
        }

        private void fetchLikedPages()
        {
            listBoxLikedPages.Invoke(new Action(() => listBoxLikedPages.Items.Clear()));

            listBoxLikedPages.Invoke(new Action(() => listBoxLikedPages.DisplayMember = "Name"));

            try
            {
                foreach (Page page in r_FormMain.LoggedInUser.LikedPages)
                {
                    listBoxLikedPages.Invoke(new Action(() => listBoxLikedPages.Items.Add(page)));
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
            new Thread(fetchPosts).Start();
        }

        private void fetchPosts()
        {
            FacebookObjectCollection<Post> allPosts = null;

            Task.Run(() =>
            {
                allPosts = r_FormMain.LoggedInUser.Posts;

                if (!listBoxViewPosts.InvokeRequired)
                {
                    postBindingSource.DataSource = allPosts;
                }
                else
                {
                    listBoxViewPosts.Invoke(new Action(() => postBindingSource.DataSource = allPosts));
                }
            });
        }
    }
}
