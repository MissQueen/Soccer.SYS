﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soccer.SYS.DBController
{
    class UserUtil
    {
        public string userid { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public UserUtil()
        {
        }

        public UserUtil(string username, string password)
        {
            this.username = username;
            this.password = password;
        }


    }
}
