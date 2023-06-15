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
        private readonly ErrorMessageVisitor r_ErrorMessageVisitor;

        public FormActivityStatics(FormMain i_FormMain)
        {
            InitializeComponent();
            r_FormMain = i_FormMain;
            LogicManager.CreateManager(r_FormMain.LoggedInUser);
            BackgroundImage = r_BackgroundImage;
            r_ErrorMessageVisitor = new ErrorMessageVisitor();
        }

        private void buttonMaximumActivity_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show($"The maximum number of photos you have uploaded to Facebook is: {LogicManager.Instance.GetMaxActivity()} in month {LogicManager.Instance.GetMaxMonth()}", "Maximum activity");
            }
            catch (Exception ex)
            {
                r_ErrorMessageVisitor.ShowGeneralProblemDueToException();
            }
        }

        private void buttonMinimalActivity_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show($"The minimum number of photos you have uploaded to Facebook is: {LogicManager.Instance.GetMinActivity()} in month {LogicManager.Instance.GetMinMonth()}", "Minimum activity");
            }
            catch (Exception ex)
            {
                r_ErrorMessageVisitor.ShowGeneralProblemDueToException();
            }
        }
    }
}
