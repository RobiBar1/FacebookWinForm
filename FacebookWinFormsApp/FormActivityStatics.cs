﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicFacebookFeatures.Properties;
using FacebookLogic;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class FormActivityStatics : Form
    {
        private readonly Image r_BackgroundImage = Resources.statisticFacebook;
        private readonly FormMain r_FormMain;
        private readonly ActivityStaticsLogic r_activityStaticsLogic;
        private int m_MaxActivity;
        private int m_MaxMonth;
        private int m_MinMonth;
        private int m_MinActivity;
        public FormActivityStatics(FormMain i_FormMain)
        {
            InitializeComponent();
            r_FormMain = i_FormMain; 
            r_activityStaticsLogic = new ActivityStaticsLogic(r_FormMain.LoggedInUser);
            BackgroundImage = r_BackgroundImage;
        }

        private void buttonMaximumActivity_Click(object sender, EventArgs e)
        {
            r_activityStaticsLogic.ActivityStatics();
            MessageBox.Show($"The maximum number of photos you have uploaded to Facebook is: {r_activityStaticsLogic.MaxActivity} in month {r_activityStaticsLogic.MaxMonth}" );
        }

        private void buttonMinimalActivity_Click(object sender, EventArgs e)
        {
            r_activityStaticsLogic.ActivityStatics();
            MessageBox.Show($"The minimum number of photos you have uploaded to Facebook is: {r_activityStaticsLogic.MinActivity} in month {r_activityStaticsLogic.MinMonth}");
        }
    }
}
