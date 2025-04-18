﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public interface IErrorMessageVisitor
    {
        void ShowLoginError();

        void ShowConnectingToFacebookServersError();

        void ShowPostNotUploaded();

        void ShowGeneralProblemDueToException();
    }
}
