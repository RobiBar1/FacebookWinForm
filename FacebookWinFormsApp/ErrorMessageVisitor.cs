using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public class ErrorMessageVisitor : IErrorMessageVisitor
    {
        private const string k_ErrorMessageTitle = "Cannot import data";
        private const string k_ErrorMessage = "This information cannot currently be uploaded from Facebook servers";
        private const string k_LoginError = "First you need to be logged in!";
        private const string k_LoginErrorTitle = "Not connected";
        private const string k_PostNotUploadedError = "Post wasn't uploaded, this information cannot currently be uploaded from Facebook servers";
        private const string k_PostErrorTitle = "Post information";
        private const string k_GeneralProblemError = "A problem caused by an exception";
        private const string k_GeneralProblemErrorTitle = "System exception";

        public void ShowConnectingToFacebookServersError()
        {
            MessageBox.Show(k_ErrorMessage, k_ErrorMessageTitle);
        }

        public void ShowGeneralProblemDueToException()
        {
            MessageBox.Show(k_GeneralProblemError, k_GeneralProblemErrorTitle);
        }

        public void ShowLoginError()
        {
            MessageBox.Show(k_LoginError, k_LoginErrorTitle);
        }

        public void ShowPostNotUploaded()
        {
            MessageBox.Show(k_PostNotUploadedError, k_PostErrorTitle);
        }
    }
}
