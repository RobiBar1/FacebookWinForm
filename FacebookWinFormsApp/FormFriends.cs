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
        private readonly Image r_BackgroundImage = Resources.facebookFriends;
        private readonly ErrorMessageVisitor r_ErrorMessageVisitor;

        public FormFriends(FormMain i_FormMain)
        {
            r_FormMain = i_FormMain;
            LogicManager.CreateManager(r_FormMain.LoggedInUser);
            InitializeComponent();
            BackgroundImage = r_BackgroundImage;
            r_ErrorMessageVisitor = new ErrorMessageVisitor();
        }

        private void buttonFavoritePhoto_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show($"Your max likes on a picture is : {LogicManager.Instance.CalculateMaxLikes()}", "Most popular picture");
            }
            catch (Exception exception)
            {
                r_ErrorMessageVisitor.ShowConnectingToFacebookServersError();
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
                r_ErrorMessageVisitor.ShowConnectingToFacebookServersError();
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
                r_ErrorMessageVisitor.ShowConnectingToFacebookServersError();
            }
        }
    }
}
