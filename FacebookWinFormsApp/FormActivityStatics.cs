using System;
using System.Drawing;
using System.Windows.Forms;
using BasicFacebookFeatures.Properties;
using FacebookLogic;

namespace BasicFacebookFeatures
{
    public partial class FormActivityStatics : Form
    {
        private readonly Image r_BackgroundImage = Resources.statisticFacebook;
        private readonly FormMain r_FormMain;
        private readonly ActivityStaticsLogic r_activityStaticsLogic;

        public FormActivityStatics(FormMain i_FormMain)
        {
            InitializeComponent();
            r_FormMain = i_FormMain;
            r_activityStaticsLogic = new ActivityStaticsLogic(r_FormMain.LoggedInUser);
            BackgroundImage = r_BackgroundImage;
        }

        private void buttonMaximumActivity_Click(object sender, EventArgs e)
        { 
            try
            {
                r_activityStaticsLogic.ActivityStatics();
                MessageBox.Show($"The maximum number of photos you have uploaded to Facebook is: {r_activityStaticsLogic.MaxActivity} in month {r_activityStaticsLogic.MaxMonth}", "Maximum activity");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void buttonMinimalActivity_Click(object sender, EventArgs e)
        {
            try
            {
                r_activityStaticsLogic.ActivityStatics();
                MessageBox.Show($"The minimum number of photos you have uploaded to Facebook is: {r_activityStaticsLogic.MinActivity} in month {r_activityStaticsLogic.MinMonth}", "Minimum activity");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
