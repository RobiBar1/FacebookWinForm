using System;
using System.Drawing;
using System.Windows.Forms;
using BasicFacebookFeatures.Properties;
using FacebookLogic;

namespace BasicFacebookFeatures
{
    public partial class FormFriends : Form
    {
        private const string k_ErrorMessageTitle = "Cannot import data";
        private const string k_ErrorMessage = "This information cannot currently be uploaded from Facebook servers";
        private readonly FormMain r_FormMain;
        private readonly Image r_BackgroundImage = Resources.facebookFriends;

        public FormFriends(FormMain i_FormMain)
        {
            r_FormMain = i_FormMain;
            LogicManager.CreateManager(r_FormMain.LoggedInUser);
            InitializeComponent();
            BackgroundImage = r_BackgroundImage;
        }

        private void buttonFavoritePhoto_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show($"Your max likes on a picture is : {LogicManager.Instance.CalculateMaxLikes()}", "Most popular picture");
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
                MessageBox.Show($"Your minimum likes on a picture is: {LogicManager.Instance.CalculateMinLikes()}", "Least popular picture");
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
                MessageBox.Show($"Your average likes on a picture is: {LogicManager.Instance.CalculateAvgLikes()}", "Average picture");
            }
            catch (Exception exception)
            {
                MessageBox.Show(k_ErrorMessage, k_ErrorMessageTitle);
            }
        }
    }
}
