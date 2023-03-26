using System;
using System.Drawing;
using System.Windows.Forms;
using BasicFacebookFeatures.Properties;
using FacebookLogic;

namespace BasicFacebookFeatures
{
    public partial class FormFriends : Form
    {
        private readonly FormMain r_FormMain;
        private readonly FriendsLogic r_Logic;
        private readonly Image r_BackgroundImage = Resources.facebookFriends;
        private const string k_ErrorMessageTitle = "Cannot import data";
        private const string k_ErrorMessage = "This information cannot currently be uploaded from Facebook servers";

        public FormFriends(FormMain i_FormMain)
        {
            r_FormMain = i_FormMain;
            r_Logic = new FriendsLogic(i_FormMain.LoggedInUser);
            InitializeComponent();
            BackgroundImage = r_BackgroundImage;
        }

        private FriendsLogic Logic
        { set; get; }

        private void buttonFavoritePhoto_Click(object sender, EventArgs e)
        {
            try
            {
                r_Logic.CalculateMinMaxAvgLikes();
                MessageBox.Show(string.Format("Your max likes on a picture is : {0}", Logic.MaxLikedImage),"Most popular picture");
            }
            catch (Exception exception)
            {
                MessageBox.Show(k_ErrorMessage, k_ErrorMessageTitle);
            }
        }

        private void buttonLeastFavoritePhoto_Click(object sender, EventArgs e)
        {
            try
            {
                r_Logic.CalculateMinMaxAvgLikes();
                MessageBox.Show(String.Format("Your minimum likes on a picture is: {0}", Logic.MinLikedImage), "Least popular picture");
            }
            catch (Exception exception)
            {
                MessageBox.Show(k_ErrorMessage, k_ErrorMessageTitle);
            }
        }

        private void buttonAveragePhoto_Click(object sender, EventArgs e)
        {
            try
            {
                r_Logic.CalculateMinMaxAvgLikes();
                MessageBox.Show(string.Format("Your average likes on a picture is: {0}", Logic.AvgLikedImage), "Average picture");
            }
            catch (Exception exception)
            {
                MessageBox.Show(k_ErrorMessage, k_ErrorMessageTitle);
            }
        }
    }
}
