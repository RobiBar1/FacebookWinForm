using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookLogic;

namespace BasicFacebookFeatures
{
    public partial class FormFriends : Form
    {
        private readonly FormMain r_FormMain;
        private FormFriendsLogic m_FormLogic;
        public FormFriends(FormMain i_FormMain)
        {
            r_FormMain = i_FormMain;
            m_FormLogic =  new FormFriendsLogic(i_FormMain.LoggedInUser);
            InitializeComponent();
        }

        private FormFriendsLogic FormLogic
        { set; get; }

        private FormMain FormMain {get; }
     

        private void buttonFavoritePhoto_Click(object sender, EventArgs e)
        {
            m_FormLogic.CalculateMinMaxAvgLikes();
            MessageBox.Show(String.Format("Your max likes is {0}", FormLogic.MaxLikedImage)); 
        }

        private void buttonLeastFavoritePhoto_Click(object sender, EventArgs e)
        {

        }

        private void buttonAvaragePhoto_Click(object sender, EventArgs e)
        {
            
        }
    }
}
