using System;
using System.Drawing;
using System.Windows.Forms;
using BasicFacebookFeatures.Properties;
using FacebookLogic;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class FormPostTiming : Form
    {
        private readonly Image r_BackgroundImage = Resources.facebookDetails;
        private readonly FormMain r_FormMain;
        private readonly ErrorMessageVisitor r_ErrorMessageVisitor;

        public FormPostTiming(FormMain i_FormMain)
        {
            InitializeComponent();
            BackgroundImage = r_BackgroundImage;
            r_FormMain = i_FormMain;
            r_ErrorMessageVisitor = new ErrorMessageVisitor();
        }

        private void buttOnPost_Click(object sender, EventArgs e)
        {
            MessageSchedulingLogic messageScheduling = new MessageSchedulingLogic();

            try
            {
                messageScheduling.PostUpload += new Action<MessageSchedulingLogic>(showOnUiThatPostIsUpload);
                messageScheduling.SchedulingMessage(r_FormMain.LoggedInUser, userPost.Text, userHours.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error");
            }
        }

        private void showOnUiThatPostIsUpload(MessageSchedulingLogic i_MessageScheduling)
        {
            if (i_MessageScheduling.UploadSuccessfully)
            {
                MessageBox.Show("Post was uploaded successfully", "Post information");
            }
            else
            {
                r_ErrorMessageVisitor.ShowPostNotUploaded();
            }
        }
    }
}
