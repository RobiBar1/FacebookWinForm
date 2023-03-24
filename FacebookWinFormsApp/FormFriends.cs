using System;
using System.Windows.Forms;
using FacebookLogic;

namespace BasicFacebookFeatures
{
    public partial class FormFriends : Form
    {
        private readonly FormMain r_FormMain;
        private readonly FriendsLogic m_Logic;
        public FormFriends(FormMain i_FormMain)
        {
            r_FormMain = i_FormMain;
            m_Logic =  new FriendsLogic(i_FormMain.LoggedInUser);
            InitializeComponent();
        }

        private FriendsLogic Logic
        { set; get; }

        private FormMain FormMain {get; }
        
        private void buttonFavoritePhoto_Click(object sender, EventArgs e)
        {
            try
            {
                m_Logic.CalculateMinMaxAvgLikes();
                MessageBox.Show(String.Format("Your max likes is {0}", Logic.MaxLikedImage));

            }
            catch (Exception exception)
            {
                MessageBox.Show("This information cannot currently be uploaded from Facebook servers");
            }
        
        }

        private void buttonLeastFavoritePhoto_Click(object sender, EventArgs e)
        {
            try
            {
                m_Logic.CalculateMinMaxAvgLikes();
                MessageBox.Show(String.Format("Your max likes is {0}", Logic.MinLikedImage));

            }
            catch (Exception exception)
            {
                MessageBox.Show("This information cannot currently be uploaded from Facebook servers");
            }

        }

        private void buttonAveragePhoto_Click(object sender, EventArgs e)
        {
            try
            {
                m_Logic.CalculateMinMaxAvgLikes();
                MessageBox.Show(String.Format("Your max likes is {0}", Logic.AvrgLikedImage));

            }
            catch (Exception exception)
            {
                MessageBox.Show("This information cannot currently be uploaded from Facebook servers");
            }

        }
    }
}
