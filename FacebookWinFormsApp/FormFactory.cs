using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public class FormFactory
    {
        public static Form CreateForm(eFormType i_FormType, FormMain i_FormMain)
        {
            Form userFormChoice = null;

            switch (i_FormType)
            {
                case eFormType.FormFriends:
                    userFormChoice = new FormFriends(i_FormMain);
                    break;
                case eFormType.FormBasicDetails:
                    userFormChoice = new FormBasicDetails(i_FormMain);
                    break;
                case eFormType.FormActivityStatics:
                    userFormChoice = new FormActivityStatics(i_FormMain);
                    break;
                case eFormType.FormPostTime:
                    userFormChoice = new FormPostTiming(i_FormMain);
                    break;
            }

            return userFormChoice;
        }
    }
}
