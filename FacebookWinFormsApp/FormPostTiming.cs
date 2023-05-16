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

        public FormPostTiming(FormMain i_FormMain)
        {
            InitializeComponent();
            BackgroundImage = r_BackgroundImage;
            r_FormMain = i_FormMain;
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
            MessageBox.Show(i_MessageScheduling.UploadSuccessfully ? "Post was uploaded" : "Post wasn't uploaded, this information cannot currently be uploaded from Facebook servers", "Post information");
        }
    }
}
