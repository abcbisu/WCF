﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace ServiceEngineDll
{
    public class CustomIdentity : IIdentity
    {
        public string AuthenticationType
        {
            get;
            set;
        }

        public bool IsAuthenticated
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }
    }
}